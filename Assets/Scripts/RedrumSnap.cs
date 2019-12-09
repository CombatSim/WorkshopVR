using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedrumSnap : Snapper
{
    public static bool mancalEsq;
    public static bool mancalDir;
    public static bool paredeTras;
    public static bool paredeEsq;
    public static bool paredeDir;
    public static bool paredeCentro;
    public static bool paredeCentro2;
    public static bool tampa;
    public static bool pezinhoEsq;
    public static bool pezinhoDir;
    public static bool placaDir2;
    public static bool placaEsq;
    public static bool bateriaEsq;
    public static bool bateriaDir;
    public static bool protecaoDir;
    public static bool protecaoEsq;
    public static bool placaDir1;
    public static bool motorArma;
    public static bool tambor;
    public static bool locDir;
    public static bool locEsq;

    // Start is called before the first frame update
    void Start()
    {
        mancalDir = false;
        mancalEsq = false;
        paredeTras = false;
        paredeEsq = false;
        paredeDir = false;
        paredeCentro = false;
        paredeCentro2 = false;
        tampa = false;
        pezinhoEsq = false;
        pezinhoDir = false;
        placaDir2 = false;
        placaEsq = false;
        bateriaEsq = false;
        bateriaDir = false;
        protecaoDir = false;
        protecaoEsq = false;
        placaDir1 = false;
        motorArma = false;
        tambor = false;
        locDir = false;
        locEsq = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    override public bool CanSnapChild(string name)
    {
        bool CanSnap = false;

        if (name.StartsWith("Mancal"))
        {
            CanSnap = true;
        }
        else if (name.StartsWith("ParedeTras"))
        {
            CanSnap = paredeCentro;
        }
        else if (name.StartsWith("ParedeCentro"))
        {
            CanSnap = true;
        }
        else if (name.StartsWith("Locomocao"))
        {
            CanSnap = true;
        }
        else if (name.StartsWith("MotorArma"))
        {
            CanSnap = paredeCentro2;
        }
        else if (name.StartsWith("ParedeEsq") || name.StartsWith("ParedeDir"))
        {
            CanSnap = locDir && locEsq && paredeTras && mancalDir && mancalEsq && paredeCentro && paredeCentro2 && motorArma;
        }
        else if (name.StartsWith("Tambor"))
        {
            CanSnap = paredeEsq && paredeDir;
        }
        else if (name.StartsWith("Pezinho"))
        {
            CanSnap = paredeDir && paredeEsq;
        }
        else if (name.StartsWith("Placa") || name.StartsWith("Bateria"))
        {
            CanSnap = tambor;
        }
        else if (name.StartsWith("tampa"))
        {
            CanSnap = placaDir1 && placaDir2 && bateriaDir && bateriaEsq && placaEsq;
        }
        else if (name.StartsWith("Protecao"))
        {
            CanSnap = tampa;
        }

        Debug.Log("[RedrSnap] Checking if " + name + " can snap: " + CanSnap);
        return CanSnap;
    }

    override public void SnapChild(string name)
    {
        if (name == "MancalDir")
        {
            mancalDir = true;
        }
        else if (name == "ParedeTras")
        {
            paredeTras = true;
        }
        else if (name == "ParedeEsq")
        {
            paredeEsq = true;
        }
        else if (name == "ParedeDir")
        {
            paredeDir = true;
        }
        else if (name == "tampa")
        {
            tampa = true;
        }
        else if (name == "PezinhoEsq")
        {
            pezinhoEsq = true;
        }
        else if (name == "MancalEsq")
        {
            mancalEsq = true;
        }
        else if (name == "PezinhoDir")
        {
            pezinhoDir = true;
        }
        else if (name == "PlacaDir2")
        {
            placaDir2 = true;
        }
        else if (name == "PlacaEsq")
        {
            placaEsq = true;
        }
        else if (name == "BateriaEsq")
        {
            bateriaEsq = true;
        }
        else if (name == "BateriaDir")
        {
            bateriaDir = true;
        }
        else if (name == "ProtecaoDir")
        {
            protecaoDir = true;
        }
        else if (name == "ProtecaoEsq")
        {
            protecaoEsq = true;
        }
        else if (name == "PlacaDir1")
        {
            placaDir1 = true;
        }
        else if (name == "MotorArma")
        {
            motorArma = true;
        }
        else if (name == "LocomocaoDir")
        {
            locDir = true;
        }
        else if (name == "LocomocaoEsq")
        {
            locEsq = true;
        }
        else if (name == "ParedeCentro")
        {
            paredeCentro = true;
        }
        else if (name == "ParedeCentro2")
        {
            paredeCentro2 = true;
        }
        else if (name == "Tambor")
        {
            tambor = true;
        }
    }
}
