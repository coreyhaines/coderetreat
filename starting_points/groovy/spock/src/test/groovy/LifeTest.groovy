import spock.lang.*

class LifeTest extends spock.lang.Specification 
{
    def life = new Life()

    def "should rock"() 
    {
        expect:
        life.rocks() == "rocks"
    }

    def "should rock again"()
    {
        when:
        life.rocks()

        then:
        "rocks"
    }
}       
