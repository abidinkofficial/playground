package com.abidinkumas.headfirstspring.bootstrap;

import com.abidinkumas.headfirstspring.model.Author;
import com.abidinkumas.headfirstspring.model.Book;
import com.abidinkumas.headfirstspring.model.Publisher;
import com.abidinkumas.headfirstspring.repository.AuthorRepository;
import com.abidinkumas.headfirstspring.repository.BookRepository;
import com.abidinkumas.headfirstspring.repository.PublisherRepository;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

@Component
public class BootstrapData implements CommandLineRunner {

    private final AuthorRepository authorRepository;
    private final BookRepository bookRepository;
    private final PublisherRepository publisherRepository;

    public BootstrapData(AuthorRepository authorRepository, BookRepository bookRepository, PublisherRepository publisherRepository) {
        this.authorRepository = authorRepository;
        this.bookRepository = bookRepository;
        this.publisherRepository = publisherRepository;
    }

    @Override
    public void run(String... args) throws Exception {

        Publisher pegasus = new Publisher("Pegasus Yayıncılık", "Gümüşsuyu mah. Beyoğlu, İstanbul");
        publisherRepository.save(pegasus);

        Author meik = new Author("Meik", "Wiking");
        Book lykke = new Book("Lykke", "100");
        meik.getBooks().add(lykke);
        lykke.getAuthors().add(meik);
        lykke.setPublisher(pegasus);
        pegasus.getBooks().add(lykke);

        authorRepository.save(meik);
        bookRepository.save(lykke);
        publisherRepository.save(pegasus);

        Author wells = new Author("Herbert George", "Wells");
        Book timeMachine = new Book("The Time Machine", "101");
        wells.getBooks().add(timeMachine);
        timeMachine.getAuthors().add(wells);
        timeMachine.setPublisher(pegasus);
        pegasus.getBooks().add(timeMachine);

        authorRepository.save(wells);
        bookRepository.save(timeMachine);
        publisherRepository.save(pegasus);

        System.out.println("Started in Bootstrap");
        System.out.println("Number of books: " + bookRepository.count());
        System.out.println("Number of publishers: " + publisherRepository.count());
        System.out.println("Publisher's books: " + pegasus.getBooks().size());

    }
}
