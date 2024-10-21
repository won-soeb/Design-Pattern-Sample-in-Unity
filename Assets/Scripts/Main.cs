using UnityEngine;

public class Main : MonoBehaviour
{
    private void Start()
    {
        #region �Ļ�� ���� ����
        //FacadeManager facadeManager = new FacadeManager();

        //facadeManager.Init();//�ν��Ͻ� ����
        //facadeManager.Print();
        #endregion

        #region ���� ���� ����
        //StrategyManager strategyManager = new StrategyManager();

        //strategyManager.setStrategy(new StrategyA());
        //strategyManager.ChangeStrategy("����");

        //strategyManager.setStrategy(new StrategyB());
        //strategyManager.ChangeStrategy("����");
        #endregion

        #region ���ø� �޼��� ���� ����
        //TemplateMethod templateA = new MethodA();
        //templateA.AllSteps();

        //TemplateMethod templateB = new MethodB();
        //templateB.AllSteps();
        #endregion

        #region �̱��� ���� ����
        //Singleton.Instance.Print();
        #endregion

        #region ���� ���� ����
        //StateManager stateManager = new StateManager();

        //stateManager.StateA();
        //stateManager.StateB();
        //stateManager.StateB();
        //stateManager.StateA();
        #endregion

        #region ����� ���� ����
        //ServiceClass lagacy = new ServiceClass();
        //Adapter adapter = new Adapter(lagacy);

        //adapter.GetData("Tom", 50);
        #endregion

        #region �긴�� ���� ����
        //������, �߻�ȭ ��ü ����
        //IBridge ibridgeA = new InterBridgeChildA();
        //Bridge bridge = new BridgeChildA(ibridgeA);

        //ibridgeA.IPrint(ibridgeA);
        //ibridgeA.IPrint(bridge);

        //bridge.Print(bridge);
        //bridge.Print(ibridgeA);

        //Debug.Log("\n");
        ////������ ����
        //ibridgeA = new InterBridgeChildB();

        //ibridgeA.IPrint(ibridgeA);
        //ibridgeA.IPrint(bridge);

        //bridge.Print(bridge);
        //bridge.Print(ibridgeA);

        //Debug.Log("\n");        
        ////�߻�� ����
        //IBridge ibridgeB = new InterBridgeChildB();
        //bridge = new BridgeChildB(ibridgeB);

        //ibridgeA.IPrint(ibridgeA);
        //ibridgeA.IPrint(bridge);

        //bridge.Print(bridge);
        //bridge.Print(ibridgeA);
        #endregion

        #region ���丮 �޼��� ���� ����
        //FactoryMethod factoryA = new CreatorA();
        //factoryA.Create();

        //FactoryMethod factoryB = new CreatorB();
        //factoryB.Create();
        #endregion

        #region ���Ͻ� ���� ����
        //Proxy proxy = new Proxy("Proxy");
        //proxy.Use();

        //Proxy origin = new Proxy("Original");
        //origin.Use();
        #endregion

        #region ������ ���� ����
        //��ü ����
        //Subject subject = new Subject();
        //ObserverA observerA = new ObserverA();
        //ObserverB observerB = new ObserverB();
        ////������ ���
        //subject.AddObserver(observerA);
        //subject.AddObserver(observerB);
        ////�˸�
        //subject.Notify();
        //Debug.Log("\n");

        //subject.RemoveObserver(observerA);
        //subject.Notify();
        #endregion

        #region �ö��� ����Ʈ ���� ����
        //Flyweight dataA =  FlyweightFactory.GetData("A");
        //dataA.Print();
        //Flyweight dataB = FlyweightFactory.GetData("B");
        //dataB.Print();
        //Flyweight dataC = FlyweightFactory.GetData("C");
        //dataC.Print();
        #endregion

        #region �߻� ���丮 ���� ����
        //IAbstractFactory factory1 = new Factory1();
        //FactoryClient client = new FactoryClient(factory1);
        //client.Create();

        //Debug.Log("\n");
        //IAbstractFactory factory2 = new Factory2();
        //client = new FactoryClient(factory2);
        //client.Create();
        #endregion

        #region ������ ���� ����
        //IMediator mediator = new Mediator();        
        //BaseComponent componentA = new ComponentA(mediator);
        //BaseComponent componentB = new ComponentB(mediator);

        //mediator.Notify(componentA);
        //mediator.Notify(componentB);
        #endregion

        #region �湮�� ���� ����
        //IElement elementA = new ElementA();
        //IElement elementB = new ElementB();
        ////�湮�� �߰�
        //elementA.Accept(new Visitor());
        //elementB.Accept(new Visitor());
        #endregion

        #region ���� ���� ����
        ////1.
        //Builder build1 = new Builder(new BuildManager().Id(1).Name("Tom").Age(15).Job("Student"));
        //build1.Print();
        ////2.
        //BuildManager buildManager = new BuildManager();
        //buildManager.Id(2);
        //buildManager.Name("Show");
        //buildManager.Age(32);
        //buildManager.Job("Teacher");

        //Builder build2 = new Builder(buildManager);
        //build2.Print();
        #endregion

        #region ���ڷ����� ���� ����
        ////������ü
        //IDecorator origin = new Origin();
        //origin.Execute();
        //Debug.Log("\n");
        ////A ���ڷ����� ����
        //IDecorator decoratorA = new DecorateA(origin);
        //decoratorA.Execute();
        //Debug.Log("\n");
        ////A + B ���ڷ����� ����
        //IDecorator decoratorB = new DecorateB(new DecorateA(origin));
        //decoratorB.Execute();
        #endregion

        #region Ŀ�ǵ� ���� ����
        ////��� ���� ��ü
        //Receiver receiver = new Receiver();
        ////��� ��ü
        //ICommand commandA = new CommandA(receiver);
        //ICommand commandB = new CommandB(receiver);
        ////��� ���� ��ü
        //Invoker invoker = new Invoker();
        ////��� ���� �� ����
        //invoker.SetCommand(commandA);
        //invoker.Execute();
        //invoker.SetCommand(commandB);
        //invoker.Execute();
        #endregion

        #region �޸��� ���� ����
        //Originator originator = new Originator();
        //Caretaker caretaker = new Caretaker();

        //originator.Set("User1", 10);
        //caretaker.AddMemento(originator.Save());
        //originator.Set("User2", 20);
        //caretaker.AddMemento(originator.Save());

        //originator.Load(caretaker.GetMemento("User1"));
        //originator.Load(caretaker.GetMemento("User2"));
        //originator.Load(caretaker.GetMemento("Admin"));
        #endregion

        #region ������Ÿ�� ���� ����
        //Prototype prototype = new Prototype(0, "Data");
        //prototype.LoadData();
        ////��ü ����
        //Prototype cloned = prototype.Clone();
        //cloned.DataId = 1;

        //Debug.Log("\n");
        //prototype.LoadData();
        //cloned.LoadData();
        #endregion

        #region å�� ���� ���� ����
        //Handler requestA = new HandlerA();
        //Handler requestB = new HandlerB();
        //Handler requestC = new HandlerC();

        ////A-B-C������ �Ǻ�
        //requestA.SetNext(requestB);
        //requestB.SetNext(requestC);

        //requestA.Handle(6);
        #endregion

        #region ����ü ���� ����
        //Leaf1 leaf1 = new Leaf1();
        //Leaf2 leaf2 = new Leaf2();
        //Composite composite = new Composite();
        ////���� ��ü ���
        //composite.Add(leaf1);
        //composite.Add(leaf2);
        ////��ȸ
        //composite.LoadNames();

        //Debug.Log("\n");
        //composite.Remove(leaf1);
        //composite.LoadNames();
        #endregion

        #region ����-���� ���� ����
        ////���Ŀ ����
        //Broker broker = new Broker();
        ////������ ����
        //Publisher publisher = new Publisher(broker);
        ////������ ����
        //SubscriberA subscriberA = new SubscriberA();
        //SubscriberB subscriberB = new SubscriberB();
        ////������ ���
        //broker.Subscribe(subscriberA);
        //broker.Subscribe(subscriberB);
        ////�����ڿ��� �˸�(����)
        //publisher.Notify();
        #endregion
    }
}
