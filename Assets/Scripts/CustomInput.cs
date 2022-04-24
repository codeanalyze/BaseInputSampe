using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomInput : BaseInput
{
    [SerializeField]
    private BaseInputModule _inputModule = default;
    [SerializeField]
    private Image _cursor = default;

    private new void Start()
    {
        base.Start();
        _inputModule.inputOverride = this;
    }

    private void Update()
    {
        _cursor.transform.position = mousePosition;
        Debug.Log(mousePosition);
        Debug.Log(mouseScrollDelta);
        Debug.Log(mousePresent);
    }

    public override string compositionString { get; }
    public override IMECompositionMode imeCompositionMode { get; set; }
    public override Vector2 compositionCursorPos { get; set; }
    public override bool mousePresent => true;
    public override Vector2 mousePosition => Input.mousePosition;
    public override Vector2 mouseScrollDelta => Input.mouseScrollDelta;
    public override bool touchSupported { get; }
    public override int touchCount { get; }
    public override float GetAxisRaw(string axisName)
    {
        // Debug.Log(nameof(GetAxisRaw));
        return base.GetAxisRaw(axisName);
    }
    public override bool GetButtonDown(string buttonName)
    {
        // Debug.Log(nameof(GetButtonDown));
        return base.GetButtonDown(buttonName);
    }
    public override bool GetMouseButton(int button)
    {
        // Debug.Log(nameof(GetMouseButton));
        return base.GetMouseButton(button);
    }
    public override bool GetMouseButtonDown(int button)
    {
        // Debug.Log(nameof(GetMouseButtonDown));
        return base.GetMouseButtonDown(button);
    }
    public override bool GetMouseButtonUp(int button)
    {
        // Debug.Log(nameof(GetMouseButtonUp));
        return base.GetMouseButtonUp(button);
    }
    public override Touch GetTouch(int index)
    {
        // Debug.Log(nameof(GetTouch));
        return base.GetTouch(index);
    }
}
