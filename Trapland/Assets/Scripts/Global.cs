using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour
{
    //Returns a boolean value
    protected bool CheckVectorToObjectCollision2D(Vector2 _Position, GameObject _Object, bool normalPivot)
    {
        if (_Position.x >= _Object.transform.position.x - _Object.renderer.bounds.size.x / 2 && _Position.x <= _Object.transform.position.x + _Object.renderer.bounds.size.x && _Position.y >= _Object.transform.position.y - _Object.renderer.bounds.size.y / 2 && _Position.y <= _Object.transform.position.y + _Object.renderer.bounds.size.y && normalPivot == true)
            return true;
        return false;
    }
}