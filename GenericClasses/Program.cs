
using GenericClasses;

FinishEvent finalEvent = new FinishEvent();
Wrapper<Action> finalEventv2 = new Wrapper<Action>(() => {});

MiHilo t1 = new MiHilo("x", finalEventv2);
MiHilo t2 = new MiHilo("y",finalEventv2);

finalEvent.FinishAction += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();