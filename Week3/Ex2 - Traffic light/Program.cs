using Ex2___Traffic_light;

TrafficLight tl = new();
new Car(tl, 1);
new Car(tl, 2);
new Car(tl, 3);
new Taxi(tl, 4);
new Taxi(tl, 5);
new Pedestrian(tl, 6);
new Pedestrian(tl, 7);
tl.RunTrafficLight();