using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedrumSnap : Snapper
{
    public static bool MancalEsq_Placed;
    public static bool MancalDir_Placed;
    public static bool EixoArma_Placed;
    public static bool ParedeTras_Placed;
    public static bool ParedeEsq_Placed;
    public static bool ParedeDir_Placed;
    public static bool tampa_Placed;
    public static bool PezinhoEsq_Placed;
    public static bool PezinhoDir_Placed;
    public static bool PlacaDir2_Placed;
    public static bool PlacaEsq_Placed;
    public static bool BateriaEsq_Placed;
    public static bool BateriaDir_Placed;
    public static bool ProtecaoDir_Placed;
    public static bool ProtecaoEsq_Placed;
    public static bool PlacaDir1_Placed;
    public static bool SistemaArma_Placed;
    public static bool LocomocaoDir_Placed;
    public static bool LocomocaoEsq_Placed;

    // Start is called before the first frame update
    void Start()
    {
        MancalDir_Placed = false;
        MancalEsq_Placed = false;
        EixoArma_Placed = false;
        ParedeTras_Placed = false;
        ParedeEsq_Placed = false;
        ParedeDir_Placed = false;
        tampa_Placed = false;
        PezinhoEsq_Placed = false;
        PezinhoDir_Placed = false;
        PlacaDir2_Placed = false;
        PlacaEsq_Placed = false;
        BateriaEsq_Placed = false;
        BateriaDir_Placed = false;
        ProtecaoDir_Placed = false;
        ProtecaoEsq_Placed = false;
        PlacaDir1_Placed = false;
        SistemaArma_Placed = false;
        LocomocaoDir_Placed = false;
        LocomocaoEsq_Placed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    override public bool CanSnapChild(string name)
    {

        return true;
    }

    override public void SnapChild(string name)
    {
        if (name == "MancalDir")
        {
            MancalDir_Placed = true;
        }
        else if (name == "EixoArma")
        {
            EixoArma_Placed = true;
        }
        else if (name == "ParedeTras")
        {
            ParedeTras_Placed = true;
        }
        else if (name == "ParedeEsq")
        {
            ParedeEsq_Placed = true;
        }
        else if (name == "ParedeDir")
        {
            ParedeDir_Placed = true;
        }
        else if (name == "tampa")
        {
            tampa_Placed = true;
        }
        else if (name == "PezinhoEsq")
        {
            PezinhoEsq_Placed = true;
        }
        else if (name == "MancalEsq")
        {
            MancalEsq_Placed = true;
        }
        else if (name == "PezinhoDir")
        {
            PezinhoDir_Placed = true;
        }
        else if (name == "PlacaDir2")
        {
            PlacaDir2_Placed = true;
        }
        else if (name == "PlacaEsq")
        {
            PlacaEsq_Placed = true;
        }
        else if (name == "BateriaEsq")
        {
            BateriaEsq_Placed = true;
        }
        else if (name == "BateriaDir")
        {
            BateriaDir_Placed = true;
        }
        else if (name == "ProtecaoDir")
        {
            ProtecaoDir_Placed = true;
        }
        else if (name == "ProtecaoEsq")
        {
            ProtecaoEsq_Placed = true;
        }
        else if (name == "PlacaDir1")
        {
            PlacaDir1_Placed = true;
        }
        else if (name == "SistemaArma")
        {
            SistemaArma_Placed = true;
        }
        else if (name == "LocomocaoDir")
        {
            LocomocaoDir_Placed = true;
        }
        else if (name == "LocomocaoEsq")
        {
            LocomocaoEsq_Placed = true;
        }
    }
}
