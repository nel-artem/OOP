using lb17;

Complex c = new Complex(3, 4);
Console.WriteLine("Complex (3 + 4i)");
Console.WriteLine($"Modulus: {c.Modulus()}");
Console.WriteLine($"Norm:    {c.Norm2()}");

Console.WriteLine();

Vector3D v = new Vector3D(1, -5, 3);
Console.WriteLine("Vector3D (1, -5, 3)");
Console.WriteLine($"Modulus: {v.Modulus():F4}");
Console.WriteLine($"Norm:    {v.Norm2()}");  
