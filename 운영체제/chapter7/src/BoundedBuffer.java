import java.util.concurrent.Semaphore;

public class BoundedBuffer<E> {
    private static final int BUFFER_SIZE = 5;

    private int count, in, out;
    private E[] buffer;
    private Semaphore mutex;
    private Semaphore empty;
    private Semaphore full;

    public BoundedBuffer() {
        count = 0;
        in = 0;
        out = 0;
        buffer = (E[]) new Object[BUFFER_SIZE];
        mutex = new Semaphore(1);
        empty = new Semaphore(BUFFER_SIZE);
        full = new Semaphore(0);
    }

    public void insert(E item) throws InterruptedException {
        empty.acquire();
        mutex.acquire();

        buffer[in] = item;
        in = (in + 1) % BUFFER_SIZE; // in을 다음 위치로 이동
        count++;

        mutex.release();
        full.release();
    }

    public E remove() throws InterruptedException {
        full.acquire();
        mutex.acquire();

        E item = buffer[out];
        out = (out + 1) % BUFFER_SIZE; // out을 다음 위치로 이동
        count--;

        mutex.release();
        empty.release();

        return item;
    }

    public int getIn() {
        return in; // in 변수의 현재 값 반환
    }

    public int getOut() {
        return out; // out 변수의 현재 값 반환
    }
    public static void main(String[] args) {
        BoundedBuffer<Integer> buffer = new BoundedBuffer<>();

        Thread producerThread = new Thread(() -> {
            try {
                for (int i = 0; i < 10; i++) {
                    buffer.insert(i);
                    System.out.println("Produced: " + i + ", in index: " + buffer.getIn());
                    Thread.sleep(1000); // 생산 속도를 늦추기 위해 잠시 멈춥니다.
                }
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        });

        Thread consumerThread = new Thread(() -> {
            try {
                for (int i = 0; i < 10; i++) {
                    int item = buffer.remove();
                    System.out.println("Consumed: " + item + ", out index: " + buffer.getOut());
                    Thread.sleep(3000); // 소비 속도를 늦추기 위해 잠시 멈춥니다.
                }
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        });

        producerThread.start();
        consumerThread.start();
    }

    // main 메서드 생략
}
