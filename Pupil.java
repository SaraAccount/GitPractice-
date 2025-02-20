package lesson5.sara.hajbi;

import sun.text.bidi.BidiLine;

public class Pupil implements Comparable<Pupil>{
    private int id;
    private String name;

    public Pupil(int id, String name)
    {
        this.id = id;
        this.name = name;
    }

    //getters and setters
    public int getId(){return id;}
    public String getName(){return name;}
    public void setId(int value){id=value;}
    public void setName(String value){name=value;}


    @Override
    public int compareTo(Pupil p)
    {
        return name.compareTo(p.getName());
    }

    @Override
    public String toString()
    {
        return this.name;
    }

}
