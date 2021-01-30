package com.abidinkumas.headfirstspring.repository;

import com.abidinkumas.headfirstspring.model.Publisher;
import org.springframework.data.repository.CrudRepository;

public interface PublisherRepository extends CrudRepository<Publisher, Long> {
    Publisher findByNameAndAddress(String name);
}
