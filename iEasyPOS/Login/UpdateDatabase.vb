Module UpdateDatabase
    Sub Update()
        'Rename FirstName in Users
        executesql("IF COL_LENGTH('[Users]','FirstName') IS NOT NULL
        select * from Users BEGIN EXEC sp_rename 'Users.FristName', 'FirstName', 'COLUMN';   END")

        executesql("ALTER TABLE Recive ALTER COLUMN ReciveId nvarchar(100)")
        executesql("ALTER TABLE Take ALTER COLUMN TakeId nvarchar(100)")
        executesql("ALTER TABLE SaleItemOrder ALTER COLUMN StatusPrint bit")
        executesql("ALTER TABLE ReciveItem ALTER COLUMN ReciveId nvarchar(100)")
        executesql("ALTER TABLE TakeItem ALTER COLUMN TakeId nvarchar(100)")
        executesql("update Authority set AuthorityNameTH = 'ยกเลิกบิล',AuthorityNameENG = 'DeleteSale' where AuthorityId = 8")
        'Branch
        executesql("DECLARE @@HasRow int
                    DECLARE @@table_name sysname
                    DECLARE @@column_name sysname

                    SET @@table_name = 'Branch'
                    SET @@column_name = 'HqBranchId'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name))
                    FROM     syscolumns c, sysobjects o
                    Where   c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN
                        ALTER table Branch Add HqBranchId int NOT NULL DEFAULT(0)
                    END")
        'Topping
        executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
                    SET @@table_name = 'Topping'
                    SET @@column_name = 'Active'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN ALTER table Topping Add Active int NOT NULL DEFAULT(1) END")
        'CategoryItem
        executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
                    SET @@table_name = 'CategoryItem'
                    SET @@column_name = 'onPOS'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN ALTER table CategoryItem Add onPOS int NOT NULL DEFAULT(1) END")
        'Item
        executesql("DECLARE @@HasRow int
                    DECLARE @@table_name sysname
                    DECLARE @@column_name sysname

                    SET @@table_name = 'Item'
                    SET @@column_name = 'PosPriceMod'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name))
                    FROM     syscolumns c, sysobjects o
                    Where   c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN
                        ALTER table Item Add PosPriceMod int NOT NULL DEFAULT(0)
                    END")

        'PosImge
        Dim PosImg As DataTable = executesql("select SettingName from Setting where SettingName='PosImge'")
        If PosImg.Rows.Count = 0 Then
            executesql("insert into Setting (SettingName,SettingValue,SettingTypeId,TerminalId,Active) values('PosImge',0,1,1,1)")
        End If

        'Chech Payment GrabFood
        Dim PayGrab As DataTable = executesql("select * from PaymentType where PaymentName = 'GrabFood'")
        If PayGrab.Rows.Count = 0 Then
            Console.WriteLine("insert PaymentType GrabFood")
            executesql("insert into PaymentType (PaymentName,Active) values('GrabFood',1)")
        End If
        'Add Gift card Payment
        Dim DtGiftCard As DataTable = executesql("select PaymentName from PaymentType where PaymentId=18")
        If DtGiftCard.Rows.Count = 0 Then
            executesql("INSERT PaymentType (PaymentName, Active) VALUES ('Gift Card', 1)")
        End If

        'SaleTabRef BillSplit_Id
        executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
                    SET @@table_name = 'SaleTabRef'
                    SET @@column_name = 'BillSplit_Id'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN ALTER table SaleTabRef Add BillSplit_Id int NOT NULL DEFAULT(0) END")
        'SaleTabRef BillSplit_Name
        executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
                    SET @@table_name = 'SaleTabRef'
                    SET @@column_name = 'BillSplit_Name'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN ALTER table SaleTabRef Add BillSplit_Name  nvarchar(100) NULL END")

        'Sale BillSplit_Id
        executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
                    SET @@table_name = 'Sale'
                    SET @@column_name = 'BillSplit_Id'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN ALTER table Sale Add BillSplit_Id int NOT NULL DEFAULT(0) END")
        'Sale BillSplit_Name
        executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
                    SET @@table_name = 'Sale'
                    SET @@column_name = 'BillSplit_Name'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN ALTER table Sale Add BillSplit_Name  nvarchar(100) NULL END")

        'executesql("DECLARE @@HasRow int DECLARE @@table_name sysname DECLARE @@column_name sysname
        '            SET @@table_name = ''
        '            SET @@column_name = 'BillSplit_Name'
        '            SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name)) FROM syscolumns c, sysobjects o Where  c.id = o.id
        '            AND convert(sysname, o.name) = @@table_name
        '            AND convert(sysname, c.name) = @@column_name)
        '            if ( @@HasRow = 0 )
        '            BEGIN ALTER table Sale Add BillSplit_Name  nvarchar(100) NULL END")

        'add payment type lineman & robinhood
        Dim checkPaymentGrabFood As DataTable = executesql("select * from Paymenttype where PaymentName = 'GrabFood'")
        If checkPaymentGrabFood.Rows.Count = 0 Then
            executesql("insert into paymenttype(PaymentName,Active) values('GrabFood','1')")
        End If

        Dim checkPaymentLineman As DataTable = executesql("select * from Paymenttype where PaymentName = 'LINEMAN'")
        If checkPaymentLineman.Rows.Count = 0 Then
            executesql("insert into paymenttype(PaymentName,Active) values('LINEMAN','1')")
        End If

        Dim checkPaymentRobinhood As DataTable = executesql("select * from Paymenttype where PaymentName = 'Robinhood'")
        If checkPaymentRobinhood.Rows.Count = 0 Then
            executesql("insert into paymenttype(PaymentName,Active) values('Robinhood','1')")
        End If

        Dim checkPaymentShopeeFood As DataTable = executesql("select * from Paymenttype where PaymentName = 'ShopeeFood'")
        If checkPaymentShopeeFood.Rows.Count = 0 Then
            executesql("insert into paymenttype(PaymentName,Active) values('ShopeeFood','1')")
        End If

        Dim checkPaymentFoodPanda As DataTable = executesql("select * from Paymenttype where PaymentName = 'FoodPanda'")
        If checkPaymentFoodPanda.Rows.Count = 0 Then
            executesql("insert into paymenttype(PaymentName,Active) values('FoodPanda','1')")
        End If

        Dim checkAuthority As DataTable = executesql("select * from Authority where AuthorityNameTH = 'ปิดกะ'")
        If checkAuthority.Rows.Count = 0 Then
            executesql("insert into Authority(AuthorityNameTH,AuthorityNameENG,AuthorityType) values('ปิดกะ','ปิดกะ','')")

            Dim Authoritydata As DataTable = executesql("select * from Authority where AuthorityNameTH = 'ปิดกะ'")
            For i As Integer = 0 To Authoritydata.Rows.Count - 1
                Dim roledata As DataTable = executesql("select * from Roles")
                For a As Integer = 0 To roledata.Rows.Count - 1
                    executesql("insert into AuthorityRoles(RoleId,AuthorityId,Active_role) values('" & roledata(a)("roleId") & "','" & Authoritydata(i)("AuthorityId") & "',0)")
                Next
            Next
        End If
    End Sub
End Module
