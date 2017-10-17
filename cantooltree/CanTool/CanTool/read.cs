 string[] id;
        string[][] signal;
        public void readdbc()
        {
            FileStream fsRead = new FileStream("D:\\learngit\\24Team\\cantooltree\\CanTool\\CanTool\\canmsg.txt", FileMode.Open);
            StreamReader reader = new StreamReader(fsRead);
            //int fsLen = (int)fsRead.Length;
            string str;
            int m = 0,n=0;
            do
            {
                str = reader.ReadLine();
           //     MessageBox.Show("str[0]");
                if (str[0] == 'B')
                {

                    int i = str.IndexOf("BO_ ");
                    int j = str.IndexOf(" ");
                    id[m] = str.Substring(4, 3);
                    m++;
                }
                if (str[0] == 'S')
                {
                    int i = str.IndexOf("_");
                    int j = str.IndexOf(":");
                    signal[m][n] = str.Substring(i + 1, j - i - 1);
                    n++;
                }
            }
            while (str != null);
            //reader.Close();
        }
		
		 if (str[0].Equals( 'B'))
                {
                    int i = str.IndexOf("BO_ ");   //索引为0
                    int j = str.IndexOf(" ", 4, 8);//索引为7
                    id[m] = str.Substring(i + 4, j - i - 4);
                    m++;
                    Console.WriteLine(id[m]);
                }
                if (str[1] == 'S')
                {
                    int i = str.IndexOf("_", 4, 9);//索引为8
                    int j = str.IndexOf(":");
                    signal[m, n] = str.Substring(i + 1, j - i - 1);
                }                                          
            }
            while (str != null||str!="\r\r");