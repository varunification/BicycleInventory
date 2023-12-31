﻿using BicycleInventory.Components;
using BicycleInventory.DBContext;
using BicycleInventory.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var connectionString = "Server=DESKTOP-VCNB237;Database=Bicycle;Integrated Security=True;TrustServerCertificate=True;";

        var serviceProvider = new ServiceCollection()
                .AddDbContext<BicycleDbContext>(options =>
                    options.UseSqlServer(connectionString))
                .BuildServiceProvider();












        Pedal pedal1 = new Pedal(partCount: 13);
        Pedal pedal2 = new Pedal(partCount: 4);
        Tube tube1 = new Tube(partCount: 13);
        Tube tube2 = new Tube(partCount: 13);
        WheelFrame wheelFrame1 = new WheelFrame(partCount: 17);
        Wheels wheels1 = new Wheels();
        wheels1.AddComponent(tube1);
        wheels1.AddComponent(tube2);
        wheels1.AddComponent(wheelFrame1);
        Seat seat = new Seat(partCount: 13);
        Frame frame1 = new Frame(13);
        frame1.AddComponent(seat);
        frame1.AddComponent(frame1);
        frame1.AddComponent(wheels1);
        frame1.AddComponent(pedal1);
        frame1.AddComponent(pedal2);
        Console.WriteLine(frame1.GetFinishedProductCount());
    }
}