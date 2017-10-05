using UnityEngine;

public class EscaparState : HumanoState
{
    private Escapar escapar;
    public EscaparState(StateMachine sm, Humano h) : base(sm, h)
    {
    }

    public override void Awake()
    {
        humano.Animate("SprintJump");
        escapar = new Escapar(humano.GetSpeed(), humano.GetZombie());
        base.Awake();
    }

    public override void Execute()
    {
        escapar.Execute(humano.transform);
        base.Execute();
    }

    public override void Sleep()
    {
        base.Sleep();
    }
}