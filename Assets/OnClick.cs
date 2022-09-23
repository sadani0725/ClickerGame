using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public double Bitcoins = 0.0000;
    public double BitcoinAdder = 0.0001;
    public double Sciences = 0.0000;
    public double ScienceAdder = 1;

    List<Sprite> Options = new List<Sprite>();

    [SerializeField] 
    private Text BitcoinsText;
    [SerializeField] 
    private Dropdown ChangeCrypto;
     [SerializeField] 
    public Sprite Bitcoin;
     [SerializeField] 
    public Sprite Science;


    private void Start()
    {
        BitcoinsText.text = Bitcoins.ToString();

        ChangeCrypto.onValueChanged.AddListener(delegate {DropdownItemSelected(ChangeCrypto);});

        Options.Add(Bitcoin);
        Options.Add(Science);

        foreach (var option in Options)
        {
            ChangeCrypto.options.Add(new Dropdown.OptionData("", option) {image = option});
        }

        DropdownItemSelected(ChangeCrypto);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bitcoins += BitcoinAdder;
            BitcoinsText.text = Bitcoins.ToString();
        }
    }
    
    private void DropdownItemSelected(Dropdown change)
    {

    }
}
