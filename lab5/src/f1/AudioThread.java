/*package f1;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import javazoom.jl.decoder.JavaLayerException;
import javazoom.jl.player.Player;

public class AudioThread implements Runnable
{
    @Override
    public void run()
    {
        while(true)
        {
            try{
                Player p = new Player(new FileInputStream(getClass().getClassLoader().getResource("res/music.mp3").getPath()));
                p.play();
            }
            catch(FileNotFoundException | JavaLayerException e){
            }
        }
    }
}*/
