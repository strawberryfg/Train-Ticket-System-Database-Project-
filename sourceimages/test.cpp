#include<cstdio>
#include<cstdlib>
#include<cstring>
#include<iostream>
using namespace std;
char s1[111111],s2[111],s3[111],s5[111],s6[111];
char s4[1111][10];
int len;
int main()
{
	FILE *fin2=fopen("stationcodename2.out","r");
	for (int i=1;i<=128;i++)
	{
		fscanf(fin2,"%s",s4[i]);
		//printf("%s",s4[i]);
	}
	FILE *fin=fopen("stationcodename.txt","r");
	fscanf(fin,"%s",s1); 
	len=strlen(s1);
	int j=0;
	FILE *fout=fopen("stationsuo2all.out","w");
	while (j<len)
	{
		j=j+1;
		while (s1[j]!='|') j++;
		j++;
		int st=j;
		while (s1[j]!='|') j++;
		strncpy(s2,s1+st,j-st);
		s2[j-st]='\0';	
        /*bool mask=0;
		for (int i=1;i<=128;i++)
		{
			bool flag=1;
			for (int t=0;t<strlen(s4[i]);t++)
			{
				if (s4[i][t]!=s2[t]) { flag=0; break; }
			}
			if (flag==1 && s2[strlen(s4[i])]=='\0')  { mask=1; break; }
		}	
		if (mask==1) fprintf(fout,"\"%s\",",s2);*/
		//fprintf(fout,"%s",s2);
		//printf("%s",s2);			
		j++;
		st=j;
		while (s1[j]!='|') j++;		
		strncpy(s3,s1+st,j-st);
		//if (mask==1) 
		//fprintf(fout,"\"%s\",",s3);
		j++;
		st=j;
		while (s1[j]!='|') j++;
		strncpy(s5,s1+st,j-st);
		s5[j-st]='\0';
		//if (mask==1) fprintf(fout,"\"%s\",",s5);
		j++;
		st=j;
		while (s1[j]!='|') j++;
		strncpy(s6,s1+st,j-st);
		s6[j-st]='\0';
		//if (mask==1) 
		fprintf(fout,"\"%s\",",s6);
		j++;
		while (j<len && s1[j]!='@') j++;	
	}
	return 0;
}
