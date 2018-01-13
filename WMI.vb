Imports System.Management
Public Class WMI

    Public Shared Function GetWMISettingsDictionary(ByVal wmiClass As String,
                      ShoppingList() As String) As Dictionary(Of String, String)

        Dim wmiInfo As New Dictionary(Of String, String)
        Dim searcher As New ManagementObjectSearcher("select * from " & wmiClass)
        For Each item As System.Management.ManagementObject In searcher.Get

            For Each PC As System.Management.PropertyData In item.Properties

                ' perform case insensitive search 
                For Each s As String In ShoppingList
                    If s.ToLowerInvariant = PC.Name.ToLowerInvariant Then
                        If PC.Value IsNot Nothing Then
                            wmiInfo.Add(PC.Name, PC.Value.ToString)
                            ' halt search-by-name
                            Exit For
                        End If
                    End If
                Next
            Next
            ' Note: this is to prevent a crash when there is more than one item
            ' WMI reports on such as 2 display adapters; just get the first one.
            Exit For
        Next

        Return wmiInfo
    End Function


    ' helpful tool to see how WMI props are organized, discover the names etc  
    Public Shared Sub DebugWMIPropValues(wmiClass As String)

        Using searcher As New Management.ManagementObjectSearcher("Select * from " & wmiClass)
            Dim moReturn As Management.ManagementObjectCollection = searcher.Get

            For Each mo As Management.ManagementObject In moReturn
                Console.WriteLine("====")
                DebugProperties(mo)

            Next
        End Using

    End Sub

    ' debug tool to poll a management object to get the properties and values
    Private Shared Sub DebugProperties(mo As Management.ManagementObject)

        For Each pd As PropertyData In mo.Properties
            If pd.Value IsNot Nothing Then

                If pd.Value.GetType Is GetType(String()) Then
                    Dim n As Integer = 0
                    For Each s As String In CType(pd.Value, Array)
                        Console.WriteLine("{0}({1}): {2}", pd.Name, n.ToString,
                                          If(pd.Value IsNot Nothing,
                                             s,
                                             "Nothing"))
                        n += 1
                    Next
                Else
                    Console.WriteLine("{0}: {1}", pd.Name,
                                      If(pd.Value IsNot Nothing,
                                         pd.Value.ToString,
                                         "Nothing"))
                End If
            End If
        Next
    End Sub
End Class