#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QString>
#include <array>
#include <QLineEdit>
#include <QLabel>
namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:

    const int minx = 140;
    const int maxx = 710;
    static const int count = 20;

    int mintime = 0;
    int MinStack[count];
    int job[count];
    //int JobT1[count];
    long double MinQuanti = LLONG_MAX;
    int b[count];
    int c[count];
    int pos =0;
    int JobT[count];
    int stack[count];

    std::array<QLineEdit*, count> bu;
    std::array<QLineEdit*, count> cu;
    std::array<QLineEdit*, count> cost;
    std::array<QLabel*, count> lab;

    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    void printstack(int *stack);
    long int Job(int num, int time);
    //int CountJobs(int *stack);
    void print(int *JobT);
    int Check(int *JobT, int time);
    void JobTimes(int *stack, int *&JobT);
    bool CheckJobs(int *JobT);
    void Func(int time, long double quanti, int *JobT, int *stack, int pos, int a);

private slots:
    void on_pushButton_clicked();

    void on_horizontalSlider_sliderMoved(int position);
    void on_spinBox_valueChanged(int arg1);

private:
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
