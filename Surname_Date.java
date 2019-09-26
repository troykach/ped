/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sem1lab01;

import java.applet.*;
import java.awt.*;
import java.util.*;

/**
 *
 * @author Raman Zhyzhnou
 */
public class Surname_Date extends Applet {

    /**
     * Initialization method that will be called after the applet is loaded into
     * the browser.
     */
    public void init() {
        // TODO start asynchronous download of heavy resources
    }
    public void paint(Graphics g){
        Date d=new Date();
        g.drawString("Zhyzhnou,"+d.toString(), 50, 50);
    }

    // TODO overwrite start(), stop() and destroy() methods
}
