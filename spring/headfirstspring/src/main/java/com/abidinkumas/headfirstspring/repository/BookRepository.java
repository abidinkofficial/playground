package com.abidinkumas.headfirstspring.repository;

import com.abidinkumas.headfirstspring.model.Book;
import org.springframework.data.repository.CrudRepository;

public interface BookRepository extends CrudRepository<Book, Long> {
}
