//Ví dụ 3: Quản lý các đối tượng xe (xe máy, xe hơi, xe tải …)

using Lab03_KeThua_VD3_Vehicles;

internal class Program
{
    static void Main()
    {
        Vehicle car = new Car();
        car.Move();
        car.Stop();

        Vehicle mtc = new Motorcycle();
        mtc.Move();
        mtc.Stop();

        Vehicle trk = new Truck();
        trk.Move();
        trk.Stop();

    }
}
