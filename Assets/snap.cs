using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{
    public static bool CorreiaFora_Placed;
    public static bool CorreiaDentro_Placed;
    public static bool MancalDir_Placed;
    public static bool EixoArma_Placed;
    public static bool ParedeTras_Placed;
    public static bool Polia_Placed;
    public static bool ParedeEsq_Placed;
    public static bool ParedeDir_Placed;
    public static bool tampa_Placed;
    public static bool tambor_Placed;
    public static bool EspacadorBuchas_Placed;
    public static bool BuchaEsq_Placed;
    public static bool BuchaDir_Placed;
    public static bool AnelElasticoDir_Placed;
    public static bool AnelElasticoEsq_Placed;
    public static bool ParafusoEixoDir_Placed;
    public static bool Rolamento_Placed;
    public static bool ParafusoEixoEsq_Placed;
    public static bool PezinhoEsq_Placed;
    public static bool MancalEsq_Placed;
    public static bool PezinhoDir_Placed;
    public static bool PlacaDir2_Placed;
    public static bool PlacaEsq_Placed;
    public static bool BateriaEsq_Placed;
    public static bool BateriaDir_Placed;
    public static bool ProtecaoDir_Placed;
    public static bool ProtecaoEsq_Placed;
    public static bool PlacaDir1_Placed;
    public static bool ParafusoTras_Placed;
    public static bool ParafusoTampa_Placed;
    public static bool ParafusoBase_Placed;
    public static bool ParafusoParedeDir_Placed;
    public static bool ParafusoParedeEsq_Placed;
    public static bool CaixaReducaoDir_Placed;
    public static bool RodaDir_Placed;
    public static bool CuboRodaDir_Placed;
    public static bool CalotaDir_Placed;
    public static bool ParafusoRodaDir_Placed;
    public static bool MotorLocDir_Placed;
    public static bool CaixaReducaoEsq_Placed;
    public static bool RodaEsq_Placed;
    public static bool CuboRodaEsq_Placed;
    public static bool CalotaEsq_Placed;
    public static bool ParafusoRodaEsq_Placed;
    public static bool MotorLocEsq_Placed;

    // Start is called before the first frame update
    void Start()
    {
        CorreiaFora_Placed = false;
        CorreiaDentro_Placed = false;
        MancalDir_Placed = false;
        EixoArma_Placed = false;
        ParedeTras_Placed = false;
        Polia_Placed = false;
        ParedeEsq_Placed = false;
        ParedeDir_Placed = false;
        tampa_Placed = false;
        tambor_Placed = false;
        EspacadorBuchas_Placed = false;
        BuchaEsq_Placed = false;
        BuchaDir_Placed = false;
        AnelElasticoDir_Placed = false;
        AnelElasticoEsq_Placed = false;
        ParafusoEixoDir_Placed = false;
        Rolamento_Placed = false;
        ParafusoEixoEsq_Placed = false;
        PezinhoEsq_Placed = false;
        MancalEsq_Placed = false;
        PezinhoDir_Placed = false;
        PlacaDir2_Placed = false;
        PlacaEsq_Placed = false;
        BateriaEsq_Placed = false;
        BateriaDir_Placed = false;
        ProtecaoDir_Placed = false;
        ProtecaoEsq_Placed = false;
        PlacaDir1_Placed = false;
        ParafusoTras_Placed = false;
        ParafusoTampa_Placed = false;
        ParafusoBase_Placed = false;
        ParafusoParedeDir_Placed = false;
        ParafusoParedeEsq_Placed = false;
        CaixaReducaoDir_Placed = false;
        RodaDir_Placed = false;
        CuboRodaDir_Placed = false;
        CalotaDir_Placed = false;
        ParafusoRodaDir_Placed = false;
        MotorLocDir_Placed = false;
        CaixaReducaoEsq_Placed = false;
        RodaEsq_Placed = false;
        CuboRodaEsq_Placed = false;
        CalotaEsq_Placed = false;
        ParafusoRodaEsq_Placed = false;
        MotorLocEsq_Placed = false;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(new Vector3(0, 0, 0), transform.localPosition);
        //Debug.Log("Distance to other: " + dist.ToString());
        if (dist < 0.1f && checkDependencies(this.name))
        {
            transform.localPosition = new Vector3(0, 0, 0);
            transform.transform.localEulerAngles = new Vector3(0, -180, 0);
            updateGlobalVariables(this.name);
        }
        /*else
        {
            if(this.name != "CuboRodaEsq" || RodaEsq_Placed)
            {
                transform.localPosition = transform.localPosition - new Vector3(0.5f, 0, 0);
            }    
        }*/
    }

    void updateGlobalVariables(string name)
    {
        if (name == "CorreiaFora")
        {
            CorreiaFora_Placed = true;
        }
        else if (name == "CorreiaDentro")
        {
            CorreiaDentro_Placed = true;
        }
        else if (name == "MancalDir")
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
        else if (name == "Polia")
        {
            Polia_Placed = true;
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
        else if (name == "tambor")
        {
            tambor_Placed = true;
        }
        else if (name == "EspacadorBuchas")
        {
            EspacadorBuchas_Placed = true;
        }
        else if (name == "BuchaEsq")
        {
            BuchaEsq_Placed = true;
        }
        else if (name == "BuchaDir")
        {
            BuchaDir_Placed = true;
        }
        else if (name == "AnelElasticoDir")
        {
            AnelElasticoDir_Placed = true;
        }
        else if (name == "AnelElasticoEsq")
        {
            AnelElasticoEsq_Placed = true;
        }
        else if (name == "ParafusoEixoDir")
        {
            ParafusoEixoDir_Placed = true;
        }
        else if (name == "Rolamento")
        {
            Rolamento_Placed = true;
        }
        else if (name == "ParafusoEixoEsq")
        {
            ParafusoEixoEsq_Placed = true;
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
        else if (name == "ParafusoTras")
        {
            ParafusoTras_Placed = true;
        }
        else if (name == "ParafusoTampa")
        {
            ParafusoTampa_Placed = true;
        }
        else if (name == "ParafusoBase")
        {
            ParafusoBase_Placed = true;
        }
        else if (name == "ParafusoParedeDir")
        {
            ParafusoParedeDir_Placed = true;
        }
        else if (name == "ParafusoParedeEsq")
        {
            ParafusoParedeEsq_Placed = true;
        }
        else if (name == "CaixaReducaoDir")
        {
            CaixaReducaoDir_Placed = true;
        }
        else if (name == "RodaDir")
        {
            RodaDir_Placed = true;
        }
        else if (name == "CuboRodaDir")
        {
            CuboRodaDir_Placed = true;
        }
        else if (name == "CalotaDir")
        {
            CalotaDir_Placed = true;
        }
        else if (name == "ParafusoRodaDir")
        {
            ParafusoRodaDir_Placed = true;
        }
        else if (name == "MotorLocDir")
        {
            MotorLocDir_Placed = true;
        }
        else if (name == "CaixaReducaoEsq")
        {
            CaixaReducaoEsq_Placed = true;
        }
        else if (name == "RodaEsq")
        {
            RodaEsq_Placed = true;
        }
        else if (name == "CuboRodaEsq")
        {
            CuboRodaEsq_Placed = true;
        }
        else if (name == "CalotaEsq")
        {
            CalotaEsq_Placed = true;
        }
        else if (name == "ParafusoRodaEsq")
        {
            ParafusoRodaEsq_Placed = true;
        }
        else if (name == "MotorLocEsq")
        {
            MotorLocEsq_Placed = true;
        }
    }

    bool checkDependencies(string name)
    {
        if (name == "CorreiaFora" && Polia_Placed)
        {
            return true;
        }
        else if (name == "CorreiaDentro" && Polia_Placed)
        {
            return true;
        }
        else if (name == "MancalDir" && CorreiaDentro_Placed && CorreiaFora_Placed)
        {
            return true;
        }
        else if (name == "EixoArma" && ParedeEsq_Placed)
        {
            return true;
        }
        else if (name == "ParedeTras" && BateriaDir_Placed && BateriaEsq_Placed && PlacaDir1_Placed && PlacaDir2_Placed && PlacaEsq_Placed)
        {
            return true;
        }
        else if (name == "Polia")
        {
            return true;
        }
        else if (name == "ParedeEsq" && AnelElasticoEsq_Placed)
        {
            return true;
        }
        else if (name == "ParedeDir" && AnelElasticoDir_Placed)
        {
            return true;
        }
        else if (name == "tampa")
        {
            return true;
        }
        else if (name == "tambor")
        {
            return true;
        }
        else if (name == "EspacadorBuchas" && tambor_Placed)
        {
            return true;
        }
        else if (name == "BuchaEsq" && EspacadorBuchas_Placed)
        {
            return true;
        }
        else if (name == "BuchaDir")
        {
            return true;
        }
        else if (name == "AnelElasticoDir" && BuchaDir_Placed)
        {
            return true;
        }
        else if (name == "AnelElasticoEsq" && BuchaEsq_Placed)
        {
            return true;
        }
        else if (name == "ParafusoEixoDir" && ParedeDir_Placed)
        {
            return true;
        }
        else if (name == "Rolamento")
        {
            return true;
        }
        else if (name == "ParafusoEixoEsq" && EixoArma_Placed)
        {
            return true;
        }
        else if (name == "PezinhoEsq")
        {
            return true;
        }
        else if (name == "MancalEsq")
        {
            return true;
        }
        else if (name == "PezinhoDir")
        {
            return true;
        }
        else if (name == "PlacaDir2")
        {
            return true;
        }
        else if (name == "PlacaEsq")
        {
            return true;
        }
        else if (name == "BateriaEsq")
        {
            return true;
        }
        else if (name == "BateriaDir")
        {
            return true;
        }
        else if (name == "ProtecaoDir")
        {
            return true;
        }
        else if (name == "ProtecaoEsq")
        {
            return true;
        }
        else if (name == "PlacaDir1")
        {
            return true;
        }
        else if (name == "ParafusoTras" && ParedeTras_Placed)
        {
            return true;
        }
        else if (name == "ParafusoTampa" && tampa_Placed)
        {
            return true;
        }
        else if (name == "ParafusoBase")
        {
            return true;
        }
        else if (name == "ParafusoParedeDir" && ParedeDir_Placed)
        {
            return true;
        }
        else if (name == "ParafusoParedeEsq" && ParedeEsq_Placed)
        {
            return true;
        }
        else if (name == "CaixaReducaoDir")
        {
            return true;
        }
        else if (name == "RodaDir" && CaixaReducaoDir_Placed)
        {
            return true;
        }
        else if (name == "CuboRodaDir" && RodaDir_Placed)
        {
            return true;
        }
        else if (name == "CalotaDir" && CuboRodaDir_Placed)
        {
            return true;
        }
        else if (name == "ParafusoRodaDir" && CalotaDir_Placed)
        {
            return true;
        }
        else if (name == "MotorLocDir" && CaixaReducaoDir_Placed)
        {
            return true;
        }
        else if (name == "CaixaReducaoEsq")
        {
            return true;
        }
        if (name == "RodaEsq" && CaixaReducaoEsq_Placed)
        {
            return true;
        }
        else if (name == "CuboRodaEsq" && RodaEsq_Placed)
        {
            return true;
        }
        else if (name == "CalotaEsq" && CuboRodaEsq_Placed)
        {
            return true;
        }
        else if (name == "ParafusoRodaEsq" && CalotaEsq_Placed)
        {
            return true;
        }
        else if (name == "MotorLocEsq" && CaixaReducaoEsq_Placed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}