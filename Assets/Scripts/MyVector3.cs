using Unity.Mathematics;
using UnityEngine;

public class MyVector3
{
    
    float x;
    float y;
    float z;
    float magnitud;

    //Costructor
    public MyVector3()
    {
        x = 0f;
        y = 0f;
        z = 0f;
        magnitud = GetMagnitud();
    }

    public MyVector3(float x, float y, float z, float magnitud)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.magnitud = magnitud;
    }

    private float GetMagnitud()
    {
        if(this.magnitud > 0)
        {
            return this.magnitud;
        }
        else
        {
            this.magnitud = Mathf.Sqrt(x * x + y * y + z * z);
            return magnitud;
        }
    }

    public MyVector3 Add(MyVector3 vec)
    {
       
        float x3 = vec.x + this.x;
        float y3 = vec.y + this.y;
        float z3 = vec.z + this.z;
        MyVector3 vec3 = new MyVector3(x3, y3, z3);

        return vec3;
    }

     
    //Producto escalar = Cos: u*v / |u|*|v|
    //Normalizar un vector = |v|; x/|v| + y/|v|; raiz de eso al cuadrado, debería dar 1.

    public void Normalizar()
    {
        if(this.magnitud <= 0f)
        {
            this.magnitud = GetMagnitud();
        }

        this.x / this.magnitud

    }



    //Distancia
    //Ángulo
    //Producto de vectores

}
