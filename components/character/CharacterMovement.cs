public class Run : IMover{
    public void Move(){
        Console.WriteLine("The character ran");
    }
}

public class Walk : IMover{
    public void Move(){
        Console.WriteLine("The character walked");
    }
}
