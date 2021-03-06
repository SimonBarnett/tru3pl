﻿Imports System.Data.SqlClient


Public Class OutboundSO : Inherits Upload

    Public Overrides ReadOnly Property FileName As String
        Get
            Return "SO"
        End Get
    End Property

    Public Overrides ReadOnly Property cmd(Optional par As String = "") As SqlCommand
        Get
            Dim ret As SqlCommand
            Select Case Len(Trim(par))
                Case 0
                    ret = New SqlCommand(
                        "SELECT * from v3pl_SO()", cn
                    )
                Case Else
                    ret = New SqlCommand(
                        String.Format(
                            "SELECT * from v3pl_SO() where par = '{0}'",
                            par
                        ), cn
                    )
            End Select

            ret.CommandTimeout = 500
            Return ret
        End Get
    End Property

    Public Overrides ReadOnly Property rowcount(Optional par As String = "") As SqlCommand
        Get
            Dim ret As SqlCommand
            Select Case Len(Trim(par))
                Case 0
                    ret = New SqlCommand(
                        "SELECT count(*) from v3pl_SO()", cn2
                    )
                Case Else
                    ret = New SqlCommand(
                        String.Format(
                            "SELECT count(*) from v3pl_SO() where par = '{0}'",
                            par
                        ), cn2
                    )
            End Select

            ret.CommandTimeout = 500
            Return ret
        End Get
    End Property

    Sub New()
        args.line("Getting SO data")

        With Me
            .Add("Record_Type", 0)
            .Add("Merge_Action", 1)
            .Add("Order_Id", 2)
            .Add("Order_Type", 3)
            .Add("Status", 4)
            .Add("Priority", 5)
            .Add("Ship_Dock", 6)
            .Add("Work_Group", 7)
            .Add("Consignment", 8)
            .Add("Delivery_Point", 9)
            .Add("Load_Sequence", 10)
            .Add("From_Site_Id", 11)
            .Add("To_Site_Id", 12)
            .Add("Customer_Id", 13)
            .Add("Order_Date", 14)
            .Add("Ship_By_Date", 15)
            .Add("Purchase_Order", 16)
            .Add("Contact", 17)
            .Add("Contact_Phone", 18)
            .Add("Contact_Fax", 19)
            .Add("Contact_Email", 20)
            .Add("Name", 21)
            .Add("Address1", 22)
            .Add("Address2", 23)
            .Add("Town", 24)
            .Add("County", 25)
            .Add("Postcode", 26)
            .Add("Country", 27)
            .Add("Instructions", 28)
            .Add("Repack", 29)
            .Add("Owner_Id", 30)
            .Add("Carrier_Id", 31)
            .Add("Dispatch_Method", 32)
            .Add("Service_Level", 33)
            .Add("Inv_Address_Id", 34)
            .Add("Inv_Contact", 35)
            .Add("Inv_Contact_Phone", 36)
            .Add("Inv_Contact_Fax", 37)
            .Add("Inv_Contact_Email", 38)
            .Add("Inv_Name", 39)
            .Add("Inv_Address1", 40)
            .Add("Inv_Address2", 41)
            .Add("Inv_Town", 42)
            .Add("Inv_County", 43)
            .Add("Inv_Postcode", 44)
            .Add("Inv_Country", 45)
            .Add("Deliver_By_Date", 46)
            .Add("Fastest_Carrier", 47)
            .Add("Cheapest_Carrier", 48)
            .Add("Site_Replen", 49)
            .Add("Cid_Number", 50)
            .Add("Sid_Number", 51)
            .Add("Location_Number", 52)
            .Add("Freight_Charges", 53)
            .Add("Client_Id", 54)
            .Add("Export", 55)
            .Add("Disallow_Merge_Rules", 56)
            .Add("User_Def_Type_1", 57)
            .Add("User_Def_Type_2", 58)
            .Add("User_Def_Type_3", 59)
            .Add("User_Def_Type_4", 60)
            .Add("User_Def_Type_5", 61)
            .Add("User_Def_Type_6", 62)
            .Add("User_Def_Type_7", 63)
            .Add("User_Def_Type_8", 64)
            .Add("User_Def_Chk_1", 65)
            .Add("User_Def_Chk_2", 66)
            .Add("User_Def_Chk_3", 67)
            .Add("User_Def_Chk_4", 68)
            .Add("User_Def_Date_1", 69)
            .Add("User_Def_Date_2", 70)
            .Add("User_Def_Date_3", 71)
            .Add("User_Def_Date_4", 72)
            .Add("User_Def_Num_1", 73)
            .Add("User_Def_Num_2", 74)
            .Add("User_Def_Num_3", 75)
            .Add("User_Def_Num_4", 76)
            .Add("User_Def_Note_1", 77)
            .Add("User_Def_Note_2", 78)
            .Add("Soh_Id", 79)
            .Add("Move_Task_Status", 80)
            .Add("Time_Zone_Name", 81)
            .Add("Repack_Loc_Id", 82)
            .Add("Ce_Reason_Code", 83)
            .Add("Ce_Reason_Notes", 84)
            .Add("Ce_Order_Type", 85)
            .Add("Ce_Customs_Customer", 86)
            .Add("Ce_Excise_Customer", 87)
            .Add("Ce_Instructions", 88)
            .Add("Client_Group", 89)
            .Add("Delivered_Dstamp", 90)
            .Add("Signatory", 91)
            .Add("Route_Id", 92)
            .Add("Cross_Dock_To_Site", 93)
            .Add("Web_Service_Alloc_Immed", 94)
            .Add("Web_Service_Alloc_Clean", 95)
            .Add("Disallow_Short_Ship", 96)
            .Add("Work_Order_Type", 97)
            .Add("Status_Reason_Code", 98)
            .Add("Hub_Address_Id", 99)
            .Add("Hub_Contact", 100)
            .Add("Hub_Contact_Phone", 101)
            .Add("Hub_Contact_Fax", 102)
            .Add("Hub_Contact_Email", 103)
            .Add("Hub_Name", 104)
            .Add("Hub_Address1", 105)
            .Add("Hub_Address2", 106)
            .Add("Hub_Town", 107)
            .Add("Hub_County", 108)
            .Add("Hub_Postcode", 109)
            .Add("Hub_Country", 110)
            .Add("Stage_Route_Id", 111)
            .Add("Single_Order_Sortation", 112)
            .Add("Hub_Carrier_Id", 113)
            .Add("Hub_Service_Level", 114)
            .Add("Force_Single_Carrier", 115)
            .Add("Expected_Value", 116)
            .Add("Expected_Volume", 117)
            .Add("Expected_Weight", 118)
            .Add("Tod", 119)
            .Add("Tod_Place", 120)
            .Add("Language", 121)
            .Add("Seller_Name", 122)
            .Add("Seller_Phone", 123)
            .Add("Documentation_Text_1", 124)
            .Add("Documentation_Text_2", 125)
            .Add("Documentation_Text_3", 126)
            .Add("Cod", 127)
            .Add("Cod_Value", 128)
            .Add("Cod_Currency", 129)
            .Add("Cod_Type", 130)
            .Add("Vat_Number", 131)
            .Add("Inv_Vat_Number", 132)
            .Add("Hub_Vat_Number", 133)
            .Add("Inv_Reference", 134)
            .Add("Inv_Dstamp", 135)
            .Add("Inv_Currency", 136)
            .Add("Print_Invoice", 137)
            .Add("Letter_Of_Credit", 138)
            .Add("Payment_Terms", 139)
            .Add("Subtotal_1", 140)
            .Add("Subtotal_2", 141)
            .Add("Subtotal_3", 142)
            .Add("Subtotal_4", 143)
            .Add("Freight_Cost", 144)
            .Add("Freight_Terms", 145)
            .Add("Insurance_Cost", 146)
            .Add("Misc_Charges", 147)
            .Add("Discount", 148)
            .Add("Other_Fee", 149)
            .Add("Inv_Total_1", 150)
            .Add("Inv_Total_2", 151)
            .Add("Inv_Total_3", 152)
            .Add("Inv_Total_4", 153)
            .Add("Tax_Rate_1", 154)
            .Add("Tax_Basis_1", 155)
            .Add("Tax_Amount_1", 156)
            .Add("Tax_Rate_2", 157)
            .Add("Tax_Basis_2", 158)
            .Add("Tax_Amount_2", 159)
            .Add("Tax_Rate_3", 160)
            .Add("Tax_Basis_3", 161)
            .Add("Tax_Amount_3", 162)
            .Add("Tax_Rate_4", 163)
            .Add("Tax_Basis_4", 164)
            .Add("Tax_Amount_4", 165)
            .Add("Tax_Rate_5", 166)
            .Add("Tax_Basis_5", 167)
            .Add("Tax_Amount_5", 168)
            .Add("Order_Reference", 169)
            .Add("Start_By_Date", 170)
            .Add("Metapack_Carrier_Pre", 171)
            .Add("Collective_Mode", 172)
            .Add("Contact_Mobile", 173)
            .Add("Inv_Contact_Mobile", 174)
            .Add("Hub_Contact_Mobile", 175)
            .Add("Shipment_Group", 176)
            .Add("Freight_Currency", 177)
            .Add("Ncts", 178)
            .Add("Nls_Calendar", 179)


        End With

    End Sub
End Class
