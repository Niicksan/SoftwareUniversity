<?php
/**
 * Created by PhpStorm.
 * User: Nik
 * Date: 30.7.2018 г.
 * Time: 20:34
 */

namespace SoftUniBlogBundle\Form;


use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolver;

class ArticleType extends AbstractType
{
    /**
     * (@inheritdoc)
     */
    public function buildForm(FormBuilderInterface $builder, array $options)
    {
        $builder
            ->add('title', TextType::class)
            ->add('content', TextType::class);
    }

    public function configureOptions(OptionsResolver $resolver)
    {

    }

    public function getName()
    {
       return 'soft_uni_blog_bundle_article_type';
    }
}