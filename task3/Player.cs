using System.Threading.Channels;

namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно:
 * Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3
 * методи void Play() / void Pause() / void Stop() та void Record() / void Pause() /
 * void Stop() відповідно. Створіть похідний клас Player від базових інтерфейсів IPlayable
 * та IRecodable. Написати програму, яка виконує програвання та запис.
 */
public class Player : IPlayable, IRecodable
{
 public Player()
 {
  Console.WriteLine(new string('*',30));
  Pause();
  Play();
  Record();
  Stop();
 }
 public void Pause()
 {
  Console.WriteLine("Pause");
 }

 public void Record()
 {
  Console.WriteLine("Record");
 }

 public void Play()
 {
  Console.WriteLine("Play");
 }

 public void Stop()
 {
  Console.WriteLine("Stop");
 }
}