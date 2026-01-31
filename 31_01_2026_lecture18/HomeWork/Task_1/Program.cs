
//### Task 1:  
//Представьте, что вы создаете универсальный класс-контейнер под названием `Cache`,
//который может хранить любые объекты и обеспечивает кеширование и доступ к ним.                        
// Необходимо реализовать это с помощью статического класса и обобщений.                

//Требования: 
//1.Класс `Cache < T >` должен быть статическим, чтобы можно было обращаться к нему без необходимости создавать экземпляр.
//2. Класс `Cache<T>` должен иметь методы `Add`, `Get` и `Remove` для добавления, получения и удаления объекта соответственно.
//3. Класс `Cache<T>` должен использовать обобщения, чтобы поддерживать хранение любых типов объектов.    

Cache<int>.Add(10);
Cache<int>.Add(20);
Cache<int>.Add(30);
Cache<int>.ShowList();
Console.WriteLine();

Cache<int>.Get(20);

Cache<int>.Remove(20);
Cache<int>.ShowList();

public static class Cache<T>
{
    public static List<T> listCache = new List<T>();

    public static void Add( T value)
    {
        listCache.Add(value);
    }

    public static bool  Get( T value )
    {
        for(int i = 0; i<listCache.Count; i++)
        {
            if (listCache[i].Equals(value) )
            {
                Console.WriteLine($" {listCache[i]}");
                return true;
            }
        }
        return false;
    }

    public static void Remove(T value)
    {
        for (int i = 0; i < listCache.Count; i++)
        {
            if (listCache[i].Equals(value))
            {
                listCache.Remove(listCache[i]);
                Console.WriteLine($" {listCache[i]} was deleted.");
            }
        }
    }

    public static void ShowList()
    {
        Console.WriteLine("Spisok vsekh elementov");
        foreach(var p in listCache)
        {
            Console.WriteLine($" {p}");
        }
    }
}
