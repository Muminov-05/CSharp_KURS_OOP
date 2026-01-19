//Класс: Группа
//Атрибуты:
//-Id: целое число(уникальный идентификатор группы)
//-Имя: строка(Имя группы)
//- Описание: строка(Описание группы)
//Функциональность:
//- CreateGroup(): создает новую группу с предоставленными атрибутами (идентификатор, имя и описание).
//- ReadGroup(): извлекает и отображает сведения о конкретной группе на основе ее идентификатора.
//- UpdateGroup(): обновляет атрибуты(имя и описание) определенной группы на основе ее идентификатора.
//- DeleteGroup(): удаляет определенную группу из системы на основе ее идентификатора.

var groupSer = new GroupServices();

var newGroup1 = new NewGroup(1, "PMI_1", "good Mathematics");
var newGroup2 = new NewGroup(2, "PMI_2", "best Mathematics");
var newGroup3 = new NewGroup(3, "PMI_3", "the best Mathematics");
var newGroup4 = new NewGroup(4, "PMI_4", "Mathematics");

groupSer.CreateGroup(newGroup1);
groupSer.CreateGroup(newGroup2);
groupSer.CreateGroup(newGroup3);
groupSer.CreateGroup(newGroup4);

foreach (var item in groupSer.ReadGroup())
{
    Console.WriteLine($" Group: {item.Name }    Description :{item.Description} ");
}

Console.WriteLine();
groupSer.DeleteGroup(1);
foreach (var item in groupSer.ReadGroup())
{
    Console.WriteLine($" Group: {item.Name}    Description :{item.Description} ");
}

Console.WriteLine();
var newGroup5 = new NewGroup(2, "Geology_4", "Zaminkovak");
groupSer.UpdateGroup(newGroup5);

foreach (var item in groupSer.ReadGroup())
{
    Console.WriteLine($" Group: {item.Name}    Description :{item.Description} ");
}