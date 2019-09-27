/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sem1lab01;
import java.util.*;
/**
 *
 * @author Raman Zhyzhnou
 */
public class Sem1lab01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner in=new Scanner(System.in);
        String[] data = in.nextLine().split(" ");
        int[] nums = new int[data.length];
        for (int i = 0; i < data.length; i++) {
            nums[i] = Integer.parseInt(data[i]);
        }
        int m,i,flag = 0;
        for(i=0;i<nums.length;i++)
        {
            m=nums[i];
            if(nums[i]!=0||nums[i]!=1)
            {
                for(int j=2;j<m;j++)
                {
                    if (nums[i]%j==0)
                    {
                        flag=1;
                        break;
                    }
                    
                }
                if(flag==0&&nums[i]!=1)
                    {
                        System.out.print(nums[i]+" ");
                    }
                    flag=0;
            }
        }
    }
}
    

