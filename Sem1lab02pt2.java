/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sem1lab02;

import java.util.*;
import java.io.*;

/**
 *
 * @author Raman Zhyzhnou
 */
public class Sem1lab02pt2 
{

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        // TODO code application logic here
        Scanner in=new Scanner(System.in);
        String n = in.nextLine();
        int n_int = Integer.parseInt(n);
        String[] n_rand = in.nextLine().split(" ");
        int[] n_rand_int = new int[2];
        n_rand_int[0] = Integer.parseInt(n_rand[0]);
        n_rand_int[1] = Integer.parseInt(n_rand[1]);
        int[][] inp_arr = new int[n_int][n_int]; 
        Random rnd = new Random(System.currentTimeMillis());
        for (int i=0;i<n_int;i++)
        {
            for (int j=0;j<n_int;j++)
            {
                inp_arr[i][j]=n_rand_int[0] + rnd.nextInt(n_rand_int[1]-n_rand_int[0]+1);
            }
        }
        int[][] inp_trans = new int[n_int][n_int];
        for (int i = 0; i < n_int; i++)
        {
            for (int j = 0; j < n_int; j++)
            {
                inp_trans[j][i] = inp_arr[i][j];
            }
        }
        Date d = new Date();
        String newInfa = d.toString();
        try(  FileWriter A = new FileWriter("File2pt2.html", false)) 
        {
            String newLine = System.getProperty("line.separator");
            //A.write("<html>"+newLine+"<head>"+newLine+"</head>"+newLine+"<body background='https://sun9-62.userapi.com/c855128/v855128266/103fbc/NAmB6YqPeV4.jpg'>");
            A.write("<html>"+newLine+"<head>"+newLine+"</head>"+newLine+"<body>"+newLine+"<p>Исходный массив</p>"+newLine);
            for (int i=0;i<n_int;i++)
            {
                A.write("<p>");
                for (int j=0;j<n_int;j++)
                {
                    A.write(inp_arr[i][j]+" ");
                }
                A.write("</p>"+newLine);
            }
            A.write("<p>Транспонированная матица</p>");
            for (int i=0;i<n_int;i++)
            {
                A.write("<p>");
                for (int j=0;j<n_int;j++)
                {
                    A.write(inp_trans[i][j]+" ");
                }
                A.write("</p>"+newLine);
            }
            A.write("<p><b>Zhyzhnou Raman</b></p>");

            A.write("<p>"+newInfa+"</p>");
            A.write("</body>"+newLine+"</html>");
            A.flush();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    
}
