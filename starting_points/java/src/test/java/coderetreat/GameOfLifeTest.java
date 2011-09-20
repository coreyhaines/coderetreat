package coderetreat;

import org.junit.Test;

import static org.fest.assertions.Assertions.assertThat;

public class GameOfLifeTest {

    @Test
    public void whenFooIsCalled_thenItReturnsBar() {
        assertThat(new GameOfLife().foo()).isEqualTo("bar");
    }
}
