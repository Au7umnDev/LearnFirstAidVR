using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DrawspaceMarker : MonoBehaviour
{
    [SerializeField] private Transform _markerTip;
    [SerializeField] private int _markerSize = 5;

    private Renderer _renderer;
    private Color[] _colors;
    private float _tipHeight;

    private RaycastHit _touch;
    private Drawspace _drawspace;
    private Vector2 _touchPosition, _lastTouchedPosition;
    private bool _touchedLastFrame;
    private Quaternion _lastTouchedRotation;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = _markerTip.GetComponent<Renderer>();
        _colors = Enumerable.Repeat(_renderer.material.color, _markerSize * _markerSize).ToArray();
        _tipHeight = _markerTip.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        Draw();
    }

    private void Draw()
    {
        if(Physics.Raycast(_markerTip.position, transform.up, out _touch, _tipHeight))
        {
            if(_touch.transform.CompareTag("Drawspace"))
            {
                if(_drawspace == null)
                {
                    _drawspace = _touch.transform.GetComponent<Drawspace>();
                }

                _touchPosition = new Vector2(_touch.textureCoord.x, _touch.textureCoord.y);

                var x = (int)(_touchPosition.x * _drawspace.textureSize.x - (_markerSize / 2));
                var y = (int)(_touchPosition.y * _drawspace.textureSize.y - (_markerSize / 2));

                if (y < 0 || y > _drawspace.textureSize.y || x < 0 || x > _drawspace.textureSize.x) 
                    return;

                if(_touchedLastFrame)
                {
                    _drawspace.texture.SetPixels(x, y, _markerSize, _markerSize, _colors);

                    for(float f = 0.01f; f < 1.00f; f+=0.03f)
                    {
                        var lerpX = (int)Mathf.Lerp(_lastTouchedPosition.x, x, f);
                        var lerpY = (int)Mathf.Lerp(_lastTouchedPosition.y, y, f);
                        _drawspace.texture.SetPixels(lerpX, lerpY, _markerSize, _markerSize, _colors);
                    }

                    transform.rotation = _lastTouchedRotation;

                    _drawspace.texture.Apply();
                }

                _lastTouchedPosition = new Vector2(x, y);
                _lastTouchedRotation = transform.rotation;
                _touchedLastFrame = true;
                return;
            }
        }

        _drawspace = null;
        _touchedLastFrame = false;
    }
}
