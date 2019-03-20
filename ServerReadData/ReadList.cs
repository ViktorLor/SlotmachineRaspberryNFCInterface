using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;

namespace GetArticleList
{
    public class ReadList
    {
        public ReadList()
        {
            getDatafromServer();
        }

        public void getDatafromServer()
        {
            string query;
            DateTime today = DateTime.Today;

            switch (today.DayOfWeek)
            {
                case DayOfWeek.Thursday:
                    query = "SELECT * from vi_UDS_ArticleList_1 where Pricelistindex = 1"; //Mens Day
                    break;
                case DayOfWeek.Friday:
                    query = "SELECT * from vi_UDS_ArticleList_1 where Pricelistindex = 2"; //Flate Rate
                    break;
                case DayOfWeek.Tuesday:
                    query = "SELECT * from vi_UDS_ArticleList_1 where Pricelistindex = 3"; //Ladies Day   
                    break;
                default:
                    query = "SELECT * from vi_UDS_ArticleList_1 where Pricelistindex = 4"; //Normal Day
                    break;
            }

            using (var conn = new SqlConnection(GetConnectionString()))
            using (var sqlcommand = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    File.Delete(Program.filepath + "pricelist.txt");

                    using (SqlDataReader rdr = sqlcommand.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var article = new Article();
                            article.ArticleID = Convert.ToInt32(rdr["Article"]);
                            article.Name = rdr["Articlename"].ToString();
                            article.Price = Convert.ToDecimal(rdr["Price"]);
                            File.AppendAllText(Program.filepath + "pricelist.txt",
                                article.ArticleID + "/" + article.Name + "/" + article.Price + "\n");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            generatePricelist();
        }

        private string GetConnectionString()
        {
            var conBuilder = new SqlConnectionStringBuilder();
            conBuilder.DataSource = "192.168.0.95\\Accessengine"; //192.168.0.95
            conBuilder.InitialCatalog = "Access";
            conBuilder.UserID = "Statistic";
            conBuilder.Password = "WgdBz0n!";
            conBuilder.ConnectTimeout = 5;
            return conBuilder.ConnectionString;
        }
        private void generatePricelist()
        {
            List<int> ID = new List<int>();
            string line;
            StreamReader file =
                new StreamReader(Program.filepath + "SoldProducts.config");
            file.ReadLine();
            while ((line = file.ReadLine()) != null)
            {
                ID.Add(int.Parse(line));
            }

            file.Close();

            File.Delete(Program.filepath + "Products.txt");
            List<string> pricelist = new List<string>();

            file = new StreamReader(Program.filepath + "pricelist.txt");

            while ((line = file.ReadLine()) != null)
            {
                for (int i = 0; i < ID.Count; i++)
                {
                    if (line.Contains(ID[i].ToString()))
                    {
                        pricelist.Add(line);
                    }
                }
            }
            File.AppendAllLines(Program.filepath + "Products.txt",pricelist);
        }
    }

    public class Article
    {
        public decimal ArticleID;
        public string Name;
        public decimal Price;
    }
}