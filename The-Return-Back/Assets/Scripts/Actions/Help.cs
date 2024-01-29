using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController controller, string verb)
    {
        controller.currentText.text = "type a verb followed by a noun (e.g. \"go north\")";
        controller.currentText.text += "\nAllowed Verbs:\nGo, Examine, Get, Give, Use, Inventory, TalkTo, Say, Read, Help";
    }
}
