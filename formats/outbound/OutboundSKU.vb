﻿Imports System.Data.SqlClient

Public Class OutboundSKU : Inherits Upload
    Public Overrides ReadOnly Property FileName As String
        Get
            Return "SKU"
        End Get
    End Property

    Public Overrides ReadOnly Property cmd(Optional par As String = "") As SqlCommand
        Get
            Dim ret = New SqlCommand(
                        "SELECT * from v3pl_SKU()", cn
                    )
            ret.CommandTimeout = 500
            Return ret

        End Get
    End Property

    Public Overrides ReadOnly Property rowcount(Optional par As String = "") As SqlCommand
        Get
            Dim ret = New SqlCommand(
                        "SELECT count(*) from v3pl_SKU()", cn2
                    )
            ret.CommandTimeout = 500
            Return ret

        End Get
    End Property

    Public Overrides ReadOnly Property update(ParamArray keys() As Integer) As SqlCommand
        Get
            Dim ret = New SqlCommand(
                String.Format(
                    "UPDATE PART SET ZTRX_3PLSENT = 'Y' WHERE PART= {0}",
                    keys(0)
                ), cn3
            )
            ret.CommandTimeout = 500
            Return ret
        End Get
    End Property

    Sub New()
        args.line("Getting SKU data")

        With Me
            .Add("Record_Type", 0)
            .Add("Merge_Action", 1)
            .Add("Sku_Id", 2)
            .Add("EAN", 3)
            .Add("Description", 4)
            .Add("Product_Group", 5)
            .Add("Allocation_Group", 6)
            .Add("Putaway_Group", 7)
            .Add("Each_Height", 8)
            .Add("Each_Weight", 9)
            .Add("Each_Volume", 10)
            .Add("Qc_Status", 11)
            .Add("Expiry_Reqd", 12)
            .Add("Shelf_Life", 13)
            .Add("Qc_Frequency", 14)
            .Add("Split_Lowest", 15)
            .Add("Condition_Reqd", 16)
            .Add("Origin_Reqd", 17)
            .Add("Serial_At_Pick", 18)
            .Add("Serial_At_Pack", 19)
            .Add("Pick_Count_Qty", 20)
            .Add("Count_Frequency", 21)
            .Add("Kit_Sku", 22)
            .Add("Kit_Split", 23)
            .Add("Kitting_Loc_Id", 24)
            .Add("Abc_Disable", 25)
            .Add("Handling_Class", 26)
            .Add("Obsolete_Product", 27)
            .Add("New_Product", 28)
            .Add("Disallow_Upload", 29)
            .Add("Manuf_Dstamp_Reqd", 30)
            .Add("Manuf_Dstamp_Dflt", 31)
            .Add("Min_Shelf_Life", 32)
            .Add("Colour", 33)
            .Add("Sku_Size", 34)
            .Add("Hazmat", 35)
            .Add("Hazmat_Id", 36)
            .Add("Disallow_Cross_Dock", 37)
            .Add("UPC", 38)
            .Add("Ship_Shelf_Life", 39)
            .Add("Nmfc_Number", 40)
            .Add("Each_Value", 41)
            .Add("Client_Id", 42)
            .Add("Incub_Rule", 43)
            .Add("Incub_Hours", 44)
            .Add("Each_Width", 45)
            .Add("Each_Depth", 46)
            .Add("Reorder_Trigger_Qty", 47)
            .Add("Low_Trigger_Qty", 48)
            .Add("User_Def_Type_1", 49)
            .Add("User_Def_Type_2", 50)
            .Add("User_Def_Type_3", 51)
            .Add("User_Def_Type_4", 52)
            .Add("User_Def_Type_5", 53)
            .Add("User_Def_Type_6", 54)
            .Add("User_Def_Type_7", 55)
            .Add("User_Def_Type_8", 56)
            .Add("User_Def_Chk_1", 57)
            .Add("User_Def_Chk_2", 58)
            .Add("User_Def_Chk_3", 59)
            .Add("User_Def_Chk_4", 60)
            .Add("User_Def_Date_1", 61)
            .Add("User_Def_Date_2", 62)
            .Add("User_Def_Date_3", 63)
            .Add("User_Def_Date_4", 64)
            .Add("User_Def_Num_1", 65)
            .Add("User_Def_Num_2", 66)
            .Add("User_Def_Num_3", 67)
            .Add("User_Def_Num_4", 68)
            .Add("User_Def_Note_1", 69)
            .Add("User_Def_Note_2", 70)
            .Add("Disallow_Merge_Rules", 71)
            .Add("Pack_Despatch_Repack", 72)
            .Add("Serial_At_Receipt", 73)
            .Add("Serial_Valid_Merge", 74)
            .Add("Serial_No_Reuse", 75)
            .Add("Serial_Format", 76)
            .Add("Serial_Range", 77)
            .Add("Spec_Id", 78)
            .Add("Time_Zone_Name", 79)
            .Add("Beam_Units", 80)
            .Add("Pick_Sequence", 81)
            .Add("Ce_Warehouse_Type", 82)
            .Add("Ce_Customs_Excise", 83)
            .Add("Ce_Standard_Cost", 84)
            .Add("Ce_Standard_Currency", 85)
            .Add("Disallow_Clustering", 86)
            .Add("Client_Group", 87)
            .Add("Max_Stack", 88)
            .Add("Stack_Description", 89)
            .Add("Stack_Limitation", 90)
            .Add("Ce_Duty_Stamp", 91)
            .Add("Capture_Weight", 92)
            .Add("Weigh_At_Receipt", 93)
            .Add("Upper_Weight_Tolerance", 94)
            .Add("Lower_Weight_Tolerance", 95)
            .Add("Serial_At_Loading", 96)
            .Add("Serial_At_Kitting", 97)
            .Add("Serial_At_Unkitting", 98)
            .Add("Ce_Commodity_Code", 99)
            .Add("Ce_Coo", 100)
            .Add("Ce_Cwc", 101)
            .Add("Ce_Vat_Code", 102)
            .Add("Ce_Product_Type", 103)
            .Add("Commodity_Code", 104)
            .Add("Commodity_Desc", 105)
            .Add("Family_Group", 106)
            .Add("Breakpack", 107)
            .Add("Clearable", 108)
            .Add("Stage_Route_Id", 109)
            .Add("Serial_Max_Range", 110)
            .Add("Serial_Dynamic_Range", 111)
            .Add("Expiry_At_Repack", 112)
            .Add("Udf_At_Repack", 113)
            .Add("Manufacture_At_Repack", 114)
            .Add("Repack_By_Piece", 115)
            .Add("Each_Quantity", 116)
            .Add("Collective_Mode", 117)
            .Add("Packed_Height", 118)
            .Add("Packed_Width", 119)
            .Add("Packed_Depth", 120)
            .Add("Packed_Volume", 121)
            .Add("Packed_Weight", 122)
            .Add("Awkward", 123)
            .Add("Two_Man_Lift", 124)
            .Add("Decatalogued", 125)
            .Add("Stock_Check_Rule_Id", 126)
            .Add("Unkitting_Inherit", 127)
            .Add("Serial_At_Stock_Check", 128)
            .Add("Serial_At_Stock_Adjust", 129)
            .Add("Kit_Ship_Components", 130)
            .Add("Unallocatable", 131)
            .Add("Batch_At_Kitting", 132)
            .Add("Serial_Per_Each", 133)
            .Add("Vmi_Allow_Allocation", 134)
            .Add("Vmi_Allow_Replenish", 135)
            .Add("Vmi_Allow_Interfaced", 136)
            .Add("Vmi_Allow_Manual", 137)
            .Add("Vmi_Aging_Days", 138)
            .Add("Vmi_Overstock_Qty", 139)
            .Add("Scrap_On_Return", 140)
            .Add("Nls_Calendar", 141)
            .Add("Harmonised_Product_Code", 142)
            .Add("Hanging_Garment", 143)
            .Add("Conveyable", 144)
            .Add("Fragile", 145)
            .Add("Gender", 146)
            .Add("High_Security", 147)
            .Add("Ugly", 148)
            .Add("Collatable", 149)
            .Add("Ecommerce", 150)
            .Add("Promotion", 151)
            .Add("Foldable", 152)
            .Add("Style", 153)
            .Add("Business_Unit_Code", 154)
            .Add("Tag_Merge", 155)
            .Add("Carrier_Pallet_Mixing", 156)
            .Add("No_Alloc_Back_Order", 157)
            .Add("Special_Container_Type", 158)
            .Add("Disallow_Rdt_Over_Picking", 159)
            .Add("Return_Min_Shelf_Life", 160)
            .Add("Collective_Sequence", 161)
            .Add("Weigh_At_Grid_Pick", 162)
            .Add("Ce_Excise_Product_Code", 163)
            .Add("Ce_Degree_Plato", 164)
            .Add("Ce_Designation_Origin", 165)
            .Add("Ce_Density", 166)
            .Add("Ce_Brand_Name", 167)
            .Add("Ce_Alcoholic_Strength", 168)
            .Add("Ce_Fiscal_Mark", 169)
            .Add("Ce_Size_Of_Producer", 170)
            .Add("Ce_Commercial_Desc", 171)
            .Add("Serial_No_Outbound", 172)
            .Add("Full_Pallet_At_Receipt", 173)
            .Add("Always_Full_Pallet", 174)
            .Add("Sub_Within_Product_Grp", 175)
            .Add("Serial_Check_String", 176)
            .Add("Carrier_Product_Type", 177)
            .Add("Max_Pack_Configs", 178)
            .Add("Parcel_Packing_By_Piece", 179)

        End With


    End Sub

End Class
