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
    private int[] input;/// Клиент направляет массив на сервер, чтобы посчитать его.
    //Результат
    private int[] output; /// Результат манипуляции над массивом сервером.
    //Размер массивов
    private int _size;/// Объявление размера массива серверу.
    //Конструктор
    public Client(int size){ /// 
        //Выделение памяти
        _size = size; /// 
        if(size<=0){
            input = output = null;
            return;
        }
        input = new int[size];/// Объявление массива для input.
        output = new int[size];/// Объявление массива для output.
        
    }
    //Изменить размер
    public void resize(int size){   
        input = output = null;/// Приравнивание двух массивов к "Ничему".
        GC.Collect();
        _size = size;/// Старый размер массива приравнивается новому.
        if(size <= 0){ /// Если размер массива равен нулю, то ничего не делать.
            return;
        }
        input = new int[size];/// Объявление массива для input.
        output = new int[size];/// Объявление массива для output.
    }
    //Выполнить вычисления(сделать результат)
    
    public void do_work(void){
        //Вычисления производить здесь
        if (_size == 0){
            return;
        }
        int i = 0;
        while (i < _size/2){
            output[2*i] = input [2*i+1];
            output[2*i+1] = input [2*i];
            i++;
        }
        if (_size%2){
            output[2*i] = input[2*i];
        }
      
    }    
    
    //Выдать входные данные
    public int[] get_input(void){
        //Выдавать здесь
        return input;
    }
    
    //Выдать результат
    public int[] get_output(void){
        //Выдавать здесь
        return output;
    }
    
    //Сказать размер
    public int get_size(void){
        //Выдавать здесь
        //(размер хранится в свойстве _size)
        return _size;
    }
    
    //Записать входные данные
    public void set_input(int[] _input){
        //Записывать здесь
        if(!_input.Length){
            input = output = null;
            _size = 0;
            return;
        }
        resize(_input.Length);
        int i = 0; 
        while (i<_size){
            input [i] = _input[i];
            i++;
        }
    }
}
