using System;

/*
Стандартная запись функции(метода)
<тип возвр. значения> <название> ( <тип аргумента 1> [<имя аргумента 1>] [...] )
{
    [<код>]
}

Пример:

int get_a(int a)
{
    return a;
}

void do_nothing(void)
{
    return;
}
*/

public class Client{
    //Входные данные
    private int[] input;
    //Результат
    private int[] output;
    //Размер массивов
    private int _size;
    //Конструктор
    public Client(int size){
        //Выделение памяти
        _size = size;
        if(size<=0){
            return;
        }
        input = new int[size];
        output = new int[size];
        
    }
    //Изменить размер
    public void resize(int size){       
        input = output = null;
        GC.Collect();
        _size = size;
        if(size <= 0){
            return;
        }
        input = new int[size];
        output = new int[size];
    }
    //Выполнить вычисления(сделать результат)
    public void do_work(void){
        //Вычисления производить здесь
    }    
    
    //Выдать входные данные
    public int[] get_input(void){
        //Выдавать здесь
    }
    
    //Выдать результат
    public int[] get_output(void){
        //Выдавать здесь
    }
    
    //Сказать размер
    public int get_size(void){
        //Выдавать здесь
        //(размер хранится в свойстве _size)
    }
    
    //Записать входные данные
    public void set_input(int[] _input){
        //Записывать здесь
    }
}
