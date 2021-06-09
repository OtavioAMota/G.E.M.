#include <stdio.h>
#include <stdlib.h>
#include <time.h>

	/*FILE *file;
	file = fopen("arquivos\\text.txt","w");
	fprintf(file,"0 0 0 0 1 200 -100 0 0 10 's'");
	fclose(file);
	
	file = fopen("arquivos\\text.txt","r");
	fscanf(file, "%d %d %d %d %d %d %d %d %d %d %s",&num1,&num2,&soma,&pontos,&level,&exlvl,&exlvln,&exlvlt,&exlvla,&diflvl,&reiniciar);
	printf("numero:%d %d %d",);
	fclose(file);
	return 0; */


int num=0,num2=0,soma=0,pontos=0,level=1,exlvl=200,exlvln=-100,exlvlt=0,exlvla=0,diflvl=10,delay=1; // VARIABLE INT
char reiniciar='s'; // VAR CHAR


int main(void){
	system("color 70");
	while(1==1){
		system("cls");
		num=rand()%diflvl+diflvl;
		num2=rand()%diflvl+diflvl;
		exlvlt=exlvln+exlvl;
		//printf("**************************\nView ADM:On\nBot:On\nDelay:%d\nDiflvl:%d\nExlvln:%d\nExlvl:%d\nExlvlt:%\nExlvla:%d\n",delay,diflvl,exlvln,exlvl,exlvlt,exlvla);
		printf("**************************\nExperiencia:%d/%d\nLevel:%d\nQuanto eh %d+%d?\nR:", exlvla, exlvlt, level, num, num2);
		//soma=num+num2;
		//sleep(delay);
		//printf("%d",soma);
		//sleep(1);
		scanf("%d",&soma);
		
		if(soma==num+num2){
			pontos=pontos+10;
			exlvla=exlvla+10;
		}else{
			pontos=pontos-10;
			exlvla=exlvla-10;
		}
		if(pontos==exlvl-100){
			level=level+1;
			exlvl=exlvl+100;
			diflvl=diflvl+20;
			delay=(delay+level)/(level/2);
		}
		if(pontos==exlvln){
			level=level-1;
			exlvln=exlvln-100;
			diflvl=diflvl-20;
		}
		while(level<=0){
			system("cls");
			printf("\nVoce perdeu!\nReiniciar?S/N(S para sim e N para nao)\n");
			scanf("%s",&reiniciar);
			
			if(reiniciar=='n'){
				break;
			}
			if(reiniciar=='s'){
				int num=0,num2=0,soma=0,pontos=0,level=1,exlvl=200,exlvln=-100,exlvlt=0,exlvla=0,diflvl=10,delay=1; // VARIABLE INT
				char reiniciar='s'; // VAR CHAR
			}
		}
		
	}
}
