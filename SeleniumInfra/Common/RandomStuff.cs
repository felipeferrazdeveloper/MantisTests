using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Common
{
    public static class RandomStuff
    {
        public static String RandomString(int lenght)
        {
            Random random = new Random();
            var chars = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%¨& ".ToCharArray();

            StringBuilder stringBuilder = new StringBuilder(lenght);
            for(int i = 0; i<lenght; i++)
            {
                stringBuilder.Append(chars[random.Next(0, chars.Length)]);
            }
            return stringBuilder.ToString();
        }

        public static String RandomStringUpper(int lenght)
        {
            Random random = new Random();
            var chars = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();

            StringBuilder stringBuilder = new StringBuilder(lenght);
            for (int i = 0; i < lenght; i++)
            {
                stringBuilder.Append(chars[random.Next(0, chars.Length)]);
            }
            return stringBuilder.ToString();
        }

        public static String RandomCategory()
        {
            String[] array = 
            {
                "[All Projects] 7EI2PODHPN",
                "[All Projects] 8SDWVXXR6F",
                "[All Projects] a",
                "[All Projects] app_14",
                "[All Projects] Apptest",
                "[All Projects] asasasasa",
                "[All Projects] DS2249OL",
                "[All Projects] EP1539CF",
                "[All Projects] GB7066WS",
                "[All Projects] General",
                "[All Projects] HA8264LR",
                "[All Projects] MU9657OA",
                "[All Projects] PG9754ZM",
                "[All Projects] principado",
                "[All Projects] Teste",
                "[All Projects] Teste Patrick",
                "[All Projects] Teste Paulo",
                "[All Projects] Teste Pieroni",
                "[All Projects] TesteLarissaSPB",
                "[All Projects] TesteLarissaWOR",
                "[All Projects] TesteSayoan",
                "[All Projects] UF4342MV",
                "[All Projects] UX4245MX",
                "[All Projects] XT8209IX",
                "[All Projects] XY2867XJ",
                "[All Projects] ZF0874XN"
            };
            Random random = new Random();            
            return array[random.Next(array.Length - 1)];
        }
        
        public static String RandomReproducibility()
        {
            String[] array = 
            {
                "always",
                "sometimes",
                "random",
                "have not tried",
                "unable to reproduce",
                "N/A"
            };
            Random random = new Random();            
            return array[random.Next(array.Length - 1)];
        }
        
        public static String RandomSeverity()
        {
            String[] array = 
            {
                "feature",
                "trivial",
                "text",
                "tweak",
                "minor",
                "major",
                "crash",
                "block"
            };
            Random random = new Random();            
            return array[random.Next(array.Length - 1)];
        }
        
        public static String RandomPriority()
        {
            String[] array = 
            {
                "none",
                "low",
                "normal",
                "high",
                "urgent",
                "immediate"
            };
            Random random = new Random();            
            return array[random.Next(array.Length - 1)];
        }

        public static String RandomProfile()
        {
            String[] array =
            {
			    "Desktop  Windows 10",
                "PC Windows 7", 
                "PC Windows 8", 
                "PC Windows XP",
                "Plataforma2 Teste SiSTEMA",
                "Plataformal Teste SiSTEMA",
                "PlataformaTeste SiSTEMA Windows10", 
                "PlataformaTesteHNY SiSTEMA Windows10", 
                "PlataformaTesteJUP SiSTEMA Windows10", 
                "PlataformaTesteMLS SiSTEMA Windows10", 
                "PlataformaTestePXE SiSTEMA Windows10", 
                "PlataformaTesteQVF SiSTEMA Windows10", 
                "PlataformaTesteSJB SiSTEMA Windows10", 
                "platformTest osTest osBuildTest", 
                "x86 LINUX SOLARIS", 
                "x86 LINUX SOLARIS", 
                "x86 LINUX SOLARIS", 
                "x86 LINUX SOLARIS", 
                "x86 LINUX SOLARIS", 
                "x86 LINUX SOLARIS", 
                "x86 LINUX SOLARIS", 
                "x86 WINDOWS 7", 
                "x86 WINDOWS 7", 
                "x86 WINDOWS 7", 
                "x86 WINDOWS 7", 
                "x86 WINDOWS 7", 
                "x86 WINDOWS 7", 
                "x86 WINDOWS 7"
            };
            Random random = new Random();
            return array[random.Next(array.Length - 1)];
        }
    }
}
