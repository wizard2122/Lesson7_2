using UnityEngine;

public abstract class AirbornState : MovementState
{
    private readonly AirbornStateConfig _config;

    public AirbornState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.AirbornStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartAirborne();

        Data.Speed = _config.Speed;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopAirborne();
    }

    public override void Update()
    {
        base.Update();

        Data.YVelocity -= GetGravityMultiplier()* Time.deltaTime;
    }

    protected virtual float GetGravityMultiplier() => _config.BaseGravity;
}
