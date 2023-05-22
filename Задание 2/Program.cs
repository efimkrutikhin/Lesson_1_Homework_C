int a = 5;
int b = 10;
int c = 8;
int max = 0;

if( a > b){
    max = a;
}else{
    max = b;
}
if( c > max){
    max = c;
}
Console.WriteLine(max);