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
public class Sem1lab02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        // TODO code application logic here
        Scanner in=new Scanner(System.in);
        String n = in.nextLine();
        int n_int = Integer.parseInt(n);
        String[] data = new String[n_int];
        float count=0;
        for(int i=0;i<n_int;i++)
        {
            data[i]=in.nextLine();
            count = (count*(i)+data[i].length())/(i+1);
        }
        
        Date d = new Date();
        String newInfa = d.toString();
        try(  FileWriter A = new FileWriter("File.html", false)) 
        {
            String newLine = System.getProperty("line.separator");
            A.write("<html>"+newLine+"<head>"+newLine+"</head>"+newLine+"<body background='https://sun9-62.userapi.com/c855128/v855128266/103fbc/NAmB6YqPeV4.jpg'>");
            for (int i=0;i<data.length;i++) 
            {
                if(data[i].length()<count)
                {
                    A.write("<p align=center>"+data[i]+" "+ data[i].length()+"</p>");
                }
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
