package f1;

import javax.swing.*;

public class F1
{
    public static void main(String[] args)
    {
        JFrame f = new JFrame("F1");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setSize(1000, 339);
        f.add(new Road());
        f.setVisible(true);

    }

}
