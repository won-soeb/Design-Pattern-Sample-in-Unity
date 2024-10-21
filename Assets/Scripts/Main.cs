using UnityEngine;

public class Main : MonoBehaviour
{
    private void Start()
    {
        #region 파사드 패턴 실행
        //FacadeManager facadeManager = new FacadeManager();

        //facadeManager.Init();//인스턴스 생성
        //facadeManager.Print();
        #endregion

        #region 전략 패턴 실행
        //StrategyManager strategyManager = new StrategyManager();

        //strategyManager.setStrategy(new StrategyA());
        //strategyManager.ChangeStrategy("설정");

        //strategyManager.setStrategy(new StrategyB());
        //strategyManager.ChangeStrategy("변경");
        #endregion

        #region 템플릿 메서드 패턴 실행
        //TemplateMethod templateA = new MethodA();
        //templateA.AllSteps();

        //TemplateMethod templateB = new MethodB();
        //templateB.AllSteps();
        #endregion

        #region 싱글턴 패턴 실행
        //Singleton.Instance.Print();
        #endregion

        #region 상태 패턴 실행
        //StateManager stateManager = new StateManager();

        //stateManager.StateA();
        //stateManager.StateB();
        //stateManager.StateB();
        //stateManager.StateA();
        #endregion

        #region 어댑터 패턴 실행
        //ServiceClass lagacy = new ServiceClass();
        //Adapter adapter = new Adapter(lagacy);

        //adapter.GetData("Tom", 50);
        #endregion

        #region 브릿지 패턴 실행
        //구현부, 추상화 객체 생성
        //IBridge ibridgeA = new InterBridgeChildA();
        //Bridge bridge = new BridgeChildA(ibridgeA);

        //ibridgeA.IPrint(ibridgeA);
        //ibridgeA.IPrint(bridge);

        //bridge.Print(bridge);
        //bridge.Print(ibridgeA);

        //Debug.Log("\n");
        ////구현부 변경
        //ibridgeA = new InterBridgeChildB();

        //ibridgeA.IPrint(ibridgeA);
        //ibridgeA.IPrint(bridge);

        //bridge.Print(bridge);
        //bridge.Print(ibridgeA);

        //Debug.Log("\n");        
        ////추상부 변경
        //IBridge ibridgeB = new InterBridgeChildB();
        //bridge = new BridgeChildB(ibridgeB);

        //ibridgeA.IPrint(ibridgeA);
        //ibridgeA.IPrint(bridge);

        //bridge.Print(bridge);
        //bridge.Print(ibridgeA);
        #endregion

        #region 팩토리 메서드 패턴 실행
        //FactoryMethod factoryA = new CreatorA();
        //factoryA.Create();

        //FactoryMethod factoryB = new CreatorB();
        //factoryB.Create();
        #endregion

        #region 프록시 패턴 실행
        //Proxy proxy = new Proxy("Proxy");
        //proxy.Use();

        //Proxy origin = new Proxy("Original");
        //origin.Use();
        #endregion

        #region 관찰자 패턴 실행
        //객체 생성
        //Subject subject = new Subject();
        //ObserverA observerA = new ObserverA();
        //ObserverB observerB = new ObserverB();
        ////관찰자 등록
        //subject.AddObserver(observerA);
        //subject.AddObserver(observerB);
        ////알림
        //subject.Notify();
        //Debug.Log("\n");

        //subject.RemoveObserver(observerA);
        //subject.Notify();
        #endregion

        #region 플라이 웨이트 패턴 실행
        //Flyweight dataA =  FlyweightFactory.GetData("A");
        //dataA.Print();
        //Flyweight dataB = FlyweightFactory.GetData("B");
        //dataB.Print();
        //Flyweight dataC = FlyweightFactory.GetData("C");
        //dataC.Print();
        #endregion

        #region 추상 팩토리 패턴 실행
        //IAbstractFactory factory1 = new Factory1();
        //FactoryClient client = new FactoryClient(factory1);
        //client.Create();

        //Debug.Log("\n");
        //IAbstractFactory factory2 = new Factory2();
        //client = new FactoryClient(factory2);
        //client.Create();
        #endregion

        #region 중재자 패턴 실행
        //IMediator mediator = new Mediator();        
        //BaseComponent componentA = new ComponentA(mediator);
        //BaseComponent componentB = new ComponentB(mediator);

        //mediator.Notify(componentA);
        //mediator.Notify(componentB);
        #endregion

        #region 방문자 패턴 실행
        //IElement elementA = new ElementA();
        //IElement elementB = new ElementB();
        ////방문자 추가
        //elementA.Accept(new Visitor());
        //elementB.Accept(new Visitor());
        #endregion

        #region 빌더 패턴 실행
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

        #region 데코레이터 패턴 실행
        ////원본객체
        //IDecorator origin = new Origin();
        //origin.Execute();
        //Debug.Log("\n");
        ////A 데코레이터 조합
        //IDecorator decoratorA = new DecorateA(origin);
        //decoratorA.Execute();
        //Debug.Log("\n");
        ////A + B 데코레이터 조합
        //IDecorator decoratorB = new DecorateB(new DecorateA(origin));
        //decoratorB.Execute();
        #endregion

        #region 커맨드 패턴 실행
        ////명령 수신 객체
        //Receiver receiver = new Receiver();
        ////명령 객체
        //ICommand commandA = new CommandA(receiver);
        //ICommand commandB = new CommandB(receiver);
        ////명령 실행 객체
        //Invoker invoker = new Invoker();
        ////명령 설정 및 실행
        //invoker.SetCommand(commandA);
        //invoker.Execute();
        //invoker.SetCommand(commandB);
        //invoker.Execute();
        #endregion

        #region 메멘토 패턴 실행
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

        #region 프로토타입 패턴 실행
        //Prototype prototype = new Prototype(0, "Data");
        //prototype.LoadData();
        ////객체 복사
        //Prototype cloned = prototype.Clone();
        //cloned.DataId = 1;

        //Debug.Log("\n");
        //prototype.LoadData();
        //cloned.LoadData();
        #endregion

        #region 책임 연쇄 패턴 실행
        //Handler requestA = new HandlerA();
        //Handler requestB = new HandlerB();
        //Handler requestC = new HandlerC();

        ////A-B-C순으로 판별
        //requestA.SetNext(requestB);
        //requestB.SetNext(requestC);

        //requestA.Handle(6);
        #endregion

        #region 복합체 패턴 실행
        //Leaf1 leaf1 = new Leaf1();
        //Leaf2 leaf2 = new Leaf2();
        //Composite composite = new Composite();
        ////하위 객체 등록
        //composite.Add(leaf1);
        //composite.Add(leaf2);
        ////순회
        //composite.LoadNames();

        //Debug.Log("\n");
        //composite.Remove(leaf1);
        //composite.LoadNames();
        #endregion

        #region 발행-구독 패턴 실행
        ////브로커 생성
        //Broker broker = new Broker();
        ////발행자 생성
        //Publisher publisher = new Publisher(broker);
        ////구독자 생성
        //SubscriberA subscriberA = new SubscriberA();
        //SubscriberB subscriberB = new SubscriberB();
        ////구독자 등록
        //broker.Subscribe(subscriberA);
        //broker.Subscribe(subscriberB);
        ////구독자에게 알림(발행)
        //publisher.Notify();
        #endregion
    }
}
