Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.SQLite
Imports System.Data

Namespace Receptio.Data.SQLite
    Public Class SQLiteBulkInsert
        Private m_dbCon As SQLiteConnection
        Private m_cmd As SQLiteCommand
        Private m_trans As SQLiteTransaction

        Private m_parameters As New Dictionary(Of String, System.Data.SQLite.SQLiteParameter)

        Private m_counter As UInteger = 0

        Private m_beginInsertText As String

        Public Sub New(dbConnection As SQLiteConnection, tableName As String)
            m_dbCon = dbConnection
            m_tableName = tableName

            Dim query As New StringBuilder(255)
            query.Append("INSERT INTO [")
            query.Append(tableName)
            query.Append("] (")
            m_beginInsertText = query.ToString()
        End Sub

        Private m_allowBulkInsert As Boolean = True
        Public Property AllowBulkInsert() As Boolean
            Get
                Return m_allowBulkInsert
            End Get
            Set(value As Boolean)
                m_allowBulkInsert = value
            End Set
        End Property

        Public ReadOnly Property CommandText() As String
            Get
                If m_parameters.Count < 1 Then
                    Throw New SQLiteException("You must add at least one parameter.")
                End If
                Dim sb As New StringBuilder(255)
                sb.Append(m_beginInsertText)

                For Each param As String In m_parameters.Keys
                    sb.Append("["c)
                    sb.Append(param)
                    sb.Append("]"c)
                    sb.Append(", ")
                Next
                sb.Remove(sb.Length - 2, 2)

                sb.Append(") VALUES (")

                For Each param As String In m_parameters.Keys
                    sb.Append(m_paramDelim)
                    sb.Append(param)
                    sb.Append(", ")
                Next
                sb.Remove(sb.Length - 2, 2)

                sb.Append(")")

                Return sb.ToString()
            End Get
        End Property

        Private m_commitMax As UInteger = 10000
        Public Property CommitMax() As UInteger
            Get
                Return m_commitMax
            End Get
            Set(value As UInteger)
                m_commitMax = value
            End Set
        End Property

        Private m_tableName As String
        Public ReadOnly Property TableName() As String
            Get
                Return m_tableName
            End Get
        End Property

        Private m_paramDelim As String = ":"
        Public ReadOnly Property ParamDelimiter() As String
            Get
                Return m_paramDelim
            End Get
        End Property

        Public Sub AddParameter(name As String, dbType As DbType)
            Dim param As New SQLiteParameter(m_paramDelim & name, dbType)
            m_parameters.Add(name, param)
        End Sub

        Public Sub Flush()
            Try
                If m_trans IsNot Nothing Then
                    m_trans.Commit()
                End If
            Catch ex As Exception
                Throw New Exception("Could not commit transaction. See InnerException for more details", ex)
            Finally
                If m_trans IsNot Nothing Then
                    m_trans.Dispose()
                End If

                m_trans = Nothing
                m_counter = 0
            End Try
        End Sub

        Public Sub Insert(paramValues As Object())
            If paramValues.Length <> m_parameters.Count Then
                Throw New Exception("The values array count must be equal to the count of the number of parameters.")
            End If

            m_counter += 1

            If m_counter = 1 Then
                If m_allowBulkInsert Then
                    m_trans = m_dbCon.BeginTransaction()
                End If

                m_cmd = m_dbCon.CreateCommand()
                For Each par As SQLiteParameter In m_parameters.Values
                    m_cmd.Parameters.Add(par)
                Next

                m_cmd.CommandText = Me.CommandText
            End If

            Dim i As Integer = 0
            For Each par As SQLiteParameter In m_parameters.Values
                par.Value = paramValues(i)
                i += 1
            Next

            m_cmd.ExecuteNonQuery()

            If m_counter = m_commitMax Then
                Try
                    If m_trans IsNot Nothing Then
                        m_trans.Commit()
                    End If
                Catch ex As Exception
                Finally
                    If m_trans IsNot Nothing Then
                        m_trans.Dispose()
                        m_trans = Nothing
                    End If

                    m_counter = 0
                End Try
            End If
        End Sub
    End Class
End Namespace