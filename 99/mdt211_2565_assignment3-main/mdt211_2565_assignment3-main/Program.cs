
       class Program
{
    static void Main(string[] args)
    {
        Queue<char> Input = new Queue<char>();
        int n = 0;
        while(n == 0){
           char input = char.Parse(Console.ReadLine());     
           if(input == 'L' || input == 'S' || input == 'M' ){
               Input.Push(input);
               n = 0;
           } 
           else{
            n = 1;
           }
           n = n;; 
        }
        CircularLinkedList<int> output  = new CircularLinkedList<int>();
      
        while(true){
            char T = Input.Pop();
           if(T == 'L'){
            Console.Write("1");
            Input.Push('M');
            Input.Push('M');
            output.Add(1);
           }
           else if(T == 'M'){
            Console.Write("2");
            Input.Push('S');
            Input.Push('S');
            Input.Push('S');
            output.Add(2);
           }
           else if(T == 'S'){
            Console.Write("3");
            output.Add(3);
           }
           if(Input.GetLength() == 0){
            break;
           }

        }
        int N = 0;
        while(true){
            if(N >= Input.GetLength()){
                break;
            }
            Console.WriteLine(Input.Get(N));
            N++;
        }
        

    }
}
    
