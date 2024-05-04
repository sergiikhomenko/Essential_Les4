namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно:
 * Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3
 * методи void Play() / void Pause() / void Stop() та void Record() / void Pause() /
 * void Stop() відповідно. Створіть похідний клас Player від базових інтерфейсів IPlayable
 * та IRecodable. Написати програму, яка виконує програвання та запис.
 */
public interface IRecodable
{
    public void Play();
    public void Pause();
    public void Stop();
}