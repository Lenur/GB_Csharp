/* Задача с собакой и друзьями 

Два друга движутся навстречу с заданной скоростью. Скорость первого — 1 м/с, второго —  2 м/с.
У них есть собака, которая бегает со  скоростью 5 м/с. Когда друзья начинают свой  путь, собака бежит от одного друга к другому,  
добегает, разворачивается и тут же бежит  обратно. Сколько раз собака перебежит от  одного друга к другому, пока они не встретятся? 
     Решить с конкретными числами 
*/
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int distance = 10000;
int count = 0, time = 0;

while (distance>10)
{
    if (friend == 1)
    {
        time = distance/(firstFriendSpeed+dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
}
Console.Write("Собака пробежит от 1 друга ко 2 другу ");
Console.Write(count);
Console.Write(" раз.");
