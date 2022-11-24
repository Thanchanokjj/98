class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> CircularFlower = new CircularLinkedList<char>();
        Console.WriteLine("------------------");
        Console.WriteLine("1.J = Jasmine");
        Console.WriteLine("2.G = Amaranth");
        Console.WriteLine("3.O = Orchid");
        Console.WriteLine("4.R = Rose");
        Console.WriteLine("------------------");
        while(true){
            CircularFlower.Add(char.Parse(Console.ReadLine()));
            int range = CircularFlower.GetLength() - 1;
            if(CircularFlower.Get(CircularFlower.GetLength()-1) != 'J' && CircularFlower.Get(CircularFlower.GetLength()-1) != 'G' 
            && CircularFlower.Get(CircularFlower.GetLength()-1) != 'O' && CircularFlower.Get(CircularFlower.GetLength()-1) != 'R'){
                CircularFlower.Remove(CircularFlower.GetLength()-1);

                for (int i =0 ;i<CircularFlower.GetLength(); i++){
                Console.Write(CircularFlower.Get(i));
                }
                break;
            }
            else if (CircularFlower.Get(range) == 'R'){
                    if (CircularFlower.Get(range-1)==CircularFlower.Get(0)){
                            Console.WriteLine("Invalid pattern");
                            CircularFlower.Remove(range);
                    }
            }
            else if (CircularFlower.GetLength() <= 2){
                if (CircularFlower.Get(range) == 'R'){
                    if(CircularFlower.Get(0) == CircularFlower.Get(range-1)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                    else if(CircularFlower.Get(range -1) == CircularFlower.Get(range) && CircularFlower.Get(range -1) == CircularFlower.Get(range)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                }
                else if (CircularFlower.Get(range - 1) == 'R'){
                    if (CircularFlower.Get(range) == CircularFlower.Get(range - 2)){
                    Console.WriteLine("Invalid pattern");
                    CircularFlower.Remove(range);
                    }
                }
            }
            else if(CircularFlower.GetLength() >= 3){
                if (CircularFlower.Get(range) == 'R'){
                    if(CircularFlower.Get(range -1) == CircularFlower.Get(range)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                }
                else if (CircularFlower.Get(range - 1) == 'R'){
                    if (CircularFlower.Get(range) == CircularFlower.Get(range - 2)){
                    Console.WriteLine("Invalid pattern");
                    CircularFlower.Remove(range);
                    }
                }
                if(CircularFlower.Get(range) == 'G'){
                    if(CircularFlower.Get(range) == CircularFlower.Get(0) 
                    && CircularFlower.Get(range) == CircularFlower.Get(1) 
                    && CircularFlower.Get(range) == CircularFlower.Get(2)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                    else if (CircularFlower.Get(range) == CircularFlower.Get(range -1) 
                    && CircularFlower.Get(range) == CircularFlower.Get(range -2) 
                    && CircularFlower.Get(range) == CircularFlower.Get(range -3)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                    else if (CircularFlower.Get(range) == CircularFlower.Get(range -1) 
                    && CircularFlower.Get(range) == CircularFlower.Get(range -2) 
                    && CircularFlower.Get(range) == CircularFlower.Get(0)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                    else if (CircularFlower.Get(range) == CircularFlower.Get(1) 
                    && CircularFlower.Get(range) == CircularFlower.Get(0) 
                    && CircularFlower.Get(range) == CircularFlower.Get(range -1)){
                        Console.WriteLine("Invalid pattern");
                        CircularFlower.Remove(range);
                    }
                    else if (CircularFlower.Get(range - 1) == 'R'){
                        if (CircularFlower.Get(range) == CircularFlower.Get(range - 2)){
                            Console.WriteLine("Invalid pattern");
                            CircularFlower.Remove(range);
                        }
                    }
                }
            }
        }
    }
}