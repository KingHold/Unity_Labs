using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blank : MonoBehaviour
{
    public GameObject _panel;
    public Text _name;
    public Text _nameChanging;
    public Text _description;
    public Text _descriptionChanging;
    public Text _race;
    public Dropdown _raceChanging;
    public Text _class;
    public Dropdown _classChanging;
    public GameObject _name_or_desription_missing;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _panel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Return) && _nameChanging.text != "" && _nameChanging.text != " " && _descriptionChanging.text != "" && _descriptionChanging.text != " ")
        {
                _name_or_desription_missing.SetActive(false);
                _name.text = _nameChanging.text;
                _description.text = _descriptionChanging.text;

                if (_nameChanging.text == " ")
                {
                    _nameChanging.text = "";
                }
                if (_descriptionChanging.text == " ")
                {
                    _descriptionChanging.text = "";
                }

                switch (_raceChanging.value)
                {
                    case 0:
                    _race.text = "Human";
                        break;
                    case 1:
                        _race.text = "Elf";
                        break;
                    case 2:
                        _race.text = "Goblin";
                        break;
                    default:
                        break;
                }

                switch (_classChanging.value)
                {
                    case 0:
                        _class.text = "Warrior";
                        break;
                    case 1:
                        _class.text = "Magician";
                        break;
                    case 2:
                        _class.text = "Horn";
                        break;
                    default:
                        break;
                }
            _panel.SetActive(false);
        }
        else if ((_nameChanging.text == "" || _descriptionChanging.text == "") && _panel)
        {
            _name_or_desription_missing.SetActive(true);
        }

        if (_panel == false)
        {
            _name_or_desription_missing.SetActive(false);
        }
    }
}