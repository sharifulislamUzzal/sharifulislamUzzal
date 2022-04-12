using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

Console.Write("Please Enter Title: ");
string strTitle = Console.ReadLine();

Console.Write("Please Enter Fees: ");
double dblFee = Convert.ToDouble(Console.ReadLine());

Console.Write("Please Enter Class Start Date: ");
DateTime dtStartDate = Convert.ToDateTime(Console.ReadLine());


SqlCommand sqlCmd;
sqlCmd = null;


string sConn = "Data Source=ITS-UZZAL;Initial Catalog=TajStore;Integrated Security=true;User ID=sa;password=123456";
string strSQL = " insert into Courses(Title, Fees, ClassStartDate) values('" + strTitle + "'," + dblFee + ",'" + dtStartDate + "') ";


DataTable datatable = new DataTable();
SqlTransaction transaction;

using (SqlConnection objCon = new SqlConnection(sConn))
{
    objCon.Open();
    transaction = objCon.BeginTransaction();
    sqlCmd = new SqlCommand(strSQL, objCon, transaction);
    sqlCmd.Transaction = transaction;
    sqlCmd.Connection = objCon;
    sqlCmd.ExecuteNonQuery();
    transaction.Commit();
    objCon.Close();

    Console.WriteLine("Course Successfully Created!");

}

