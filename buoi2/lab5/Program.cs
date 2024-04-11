List<object> test = new List<object>();
test.Add(1);
test.Add("Hello");
test.Add(5.1);
test.Add('A');
//phải sử dụng kiểu var ở dòng dưới vì không xác định được kiểu dữ liệu chính xác (mỗi phần tử một kiểu dữ liệu)
foreach(var item in test)
{
    Console.Write($"{item} , ");
}