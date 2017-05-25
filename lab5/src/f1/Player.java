package f1;

import java.awt.Image;
import java.awt.Rectangle;
import java.awt.event.KeyEvent;
import javax.swing.ImageIcon;

public class Player
{
    public static final int MAX_V = 50;
    public static final int MAX_TOP = 5;
    public static final int MAX_BOTTOM = 232;

    Image img_c = new ImageIcon(getClass().getClassLoader().getResource("res/Player.png")).getImage();
    Image img_r = new ImageIcon(getClass().getClassLoader().getResource("res/Player_RIGHT.png")).getImage();
    Image img_l = new ImageIcon(getClass().getClassLoader().getResource("res/Player_LEFT.png")).getImage();
    Image img = img_c;

    int v = 0;
    int dv = 0;
    int s = 0;
    int layer1 = 0;
    int layer2 = 600;
    int x = 20;
    int y = 50;
    int dy = 0;

    public void move()
    {
        s += v;
        v += dv;
        if(v <= 0)
            v = 0;
        if(v >= MAX_V)
            v = MAX_V;
        y -= dy;
        if(y <= MAX_TOP)
            y = MAX_TOP;
        if(y >= MAX_BOTTOM)
            y = MAX_BOTTOM;
        if(layer2 - v <= 0)
        {
            layer1 = 0;
            layer2 = 600;
        }
        else
        {
            layer1 -= v;
            layer2 -= v;
        }
    }

    public Rectangle getRect()
    {
        return new Rectangle(x, y, 160, 50);
    }

    public void keyPressed(KeyEvent e)
    {
        int key = e.getKeyCode();
        if(key == KeyEvent.VK_RIGHT)
        {
            dv = 1;
        }
        if(key == KeyEvent.VK_LEFT)
        {
            dv = -1;
        }
        if(key == KeyEvent.VK_UP)
        {
            dy = 8;
            img = img_l;
        }
        if(key == KeyEvent.VK_DOWN)
        {
            dy = -8;
            img = img_r;
        }
    }

    public void keyReleased(KeyEvent e)
    {
        int key = e.getKeyCode();
        if(key == KeyEvent.VK_RIGHT)
        {
            dv = -1;
        }
        if(key == KeyEvent.VK_LEFT)
        {
            dv = 0;
        }
        if(key == KeyEvent.VK_UP)
        {
            dy = 0;
            img = img_c;
        }
        if(key == KeyEvent.VK_DOWN)
        {
            dy = 0;
            img = img_c;
        }
    }
}
