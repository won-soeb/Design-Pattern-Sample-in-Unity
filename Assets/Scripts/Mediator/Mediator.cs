using UnityEngine;

public class Mediator : IMediator
{
    //������Ʈ�� ����Ʈ�� �����ص� ��
    public void Notify(BaseComponent component)
    {
        Debug.Log($"{component}�� ������");
        //������Ʈ ������ ���� ���� ����
    }
    //�߰� ���� ����
}
