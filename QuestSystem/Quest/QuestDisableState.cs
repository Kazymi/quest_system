using DG.Tweening;
using Kuhpik;
using StateMachine;

public class QuestDisableState : State
{
    private readonly QuestUI m_questUI;

    private Quest currentQuest;

    public bool IsReadyToLeave;

    public void SetQuest(Quest quest)
    {
        currentQuest = quest;
    }

    public QuestDisableState(QuestUI questUI)
    {
        m_questUI = questUI;
    }

    public override void OnStateEnter()
    {
        ExitAnimation();
    }

    public override void OnStateExit()
    {
        Bootstrap.Instance.GameData.ResourceUISpawner.SpawnNewUIObject(
            Bootstrap.Instance.GameData.iconManager.GetIcon(currentQuest.AddResource), currentQuest.AddResource,
            currentQuest.AddResourceAmount, Bootstrap.Instance.GameData.CharacterControllerSystem.Player.position);
        IsReadyToLeave = false;
        m_questUI.QuestPanel.gameObject.SetActive(false);
    }

    private void ExitAnimation()
    {
        m_questUI.QuestPanel.DOShakeScale(0.7f, 0.3f).OnComplete(() => { IsReadyToLeave = true; });
    }
}